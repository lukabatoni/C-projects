namespace Chess
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Choose color: ");
            string color = Console.ReadLine();

            Console.Write("Choose figure (pawn, rook, king, knight): ");
            string figureType = Console.ReadLine();

            Figure selectedFigure;

            switch (figureType.ToLower())
            {
                case "pawn":
                    selectedFigure = new Pawn(color);
                    break;
                case "rook":
                    selectedFigure = new Rook(color);
                    break;
                case "king":
                    selectedFigure = new King(color);
                    break;
                case "knight":
                    selectedFigure = new Knight(color);
                    break;
            }

            //Console.WriteLine(selectedFigure.Color);


        }
    }
}
