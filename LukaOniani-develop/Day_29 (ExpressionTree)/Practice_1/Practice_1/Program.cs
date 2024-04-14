using System.Linq.Expressions;
using System.Reflection;

namespace Practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student{ Name = "Luka",      Age = 21, Class = 'A'},
                new Student{ Name = "Alexander", Age = 20, Class = 'A'},
                new Student{ Name = "Saba",      Age = 21, Class = 'B'},
                new Student{ Name = "Anita",     Age = 19, Class = 'B'},
                new Student{ Name = "Nika",      Age = 21, Class = 'A'}
            };

            var filteredStudents = students.Where(StudentFilter(21, 'A'));

            foreach (var student in filteredStudents)
            {
                Console.WriteLine($"Name: {student.Name} Age: {student.Age} Class: '{student.Class}' ");
            }
        }

        private static Func<Student, bool> StudentFilter(params object[] parameters)
        {
            var classType = typeof(Student);
            var parameterExpression = Expression.Parameter(classType, "stud");
            List<BinaryExpression> binExp = new List<BinaryExpression>();
            

            foreach (var param in parameters)
            {
                var propertyName = PropertyFinder(classType, param);
                var property = Expression.Property(parameterExpression, propertyName);
                var constant = Expression.Constant(param);
                binExp.Add(Expression.Equal(property, constant));
            }

            var lambdaExp = Expression.Lambda<Func<Student, bool>>(BodyCombiner(binExp), parameterExpression);
            var func = lambdaExp.Compile();

            return func;
        }

        private static BinaryExpression BodyCombiner(List<BinaryExpression> binExp)
        {
            if (binExp.Count == 0)
            {
                throw new ArgumentException("No filter conditions provided.");
            }
            return binExp.Aggregate(Expression.AndAlso);
        }

        private static PropertyInfo PropertyFinder<T>(Type type, T property)
        {
            var properties = type.GetProperties();
            PropertyInfo? resultProperty = null;
            foreach (var prop in properties)
            {
                if (prop.PropertyType == property?.GetType())
                {
                    resultProperty = prop;
                    break; 
                }
            }

            if (property == null || resultProperty == null)
            {
                throw new ArgumentException($"Property with type {property?.GetType().Name} does not exist in the {type.Name} class");
            }

            return resultProperty;
        }

    }
}
