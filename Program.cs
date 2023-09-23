namespace ChessBoard
{
    internal class Program
    {
        //Viktoria Wallström .NET23
        static void Main(string[] args)
        {   
            //Används för att stödja specialtecken
            Console.OutputEncoding = System.Text.Encoding.Unicode;


            //Se till att körningen är sann
            bool run = true;

            //En loop som körs så länge run är sann
            while(run)
            {
                try //Markerar block som kan tänkas gå fel som "catch" isåfall fångar upp
                {
                    //Ber användaren mata in en siffra
                    Console.Write("Mata in ett heltal som anger brädstorleken: ");

                    //Konverterar inmatad text till heltal som sparas i variabeln number
                    int number = int.Parse(Console.ReadLine());

                    //Strängar för svart och vit ruta
                    string black = "■";
                    string white = "□";

                    //En inre loop som reprensenterar varje rad, antal rader är det inmatade värdet
                    for (int row = 0; row < number; row++)
                    {   //En inre loop som reprensenterar varje kolumn i raden, antal kolumner är det inmatade värdet
                        for (int column = 0; column < number; column++)
                        {
                            //Om endast det ena påståendet är sant enligt XOR logik
                            //Skriv ut den svarta rutan, annars skriv ut den vita
                            if (column % 2 == 0 ^ row % 2 == 0) //Om kolumnen är ett jämnt tal XOR raden är ett jämnt tal
                            {   
                                Console.Write(black); //Skriv ut tecken utan att byta rad
                            }
                            else
                            {   
                                Console.Write(white);
                            }
                        }
                        Console.WriteLine(); //Efter varje rad har fyllt sina kolumner, byt rad
                    }
                    //Ändrar run till false om programmet gått rätt till för att avsluta programmet
                    run = false;
                //Fångar upp problemet om användaren skriver in något annat än siffror
                } catch (Exception)
                {   //Skriver endast ut till användaren vid fel inmatning
                    Console.WriteLine("Du måste skriva in ett heltal. Vänligen testa igen.");
                }
                
            }


        }       
         
    }
}