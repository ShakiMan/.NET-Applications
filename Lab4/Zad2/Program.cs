using System;
using static System.Console;

//Radosław Ścigała, 246997

namespace Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawCard("Radosław", "Ścigała", "246997", "X", 3, 30);
        }

        static void DrawCard(string firstLine, string secondLine, string index, string borderSign="X", int borderWidth=2, int minCardWidth=20)
        {
            int cardWidth = minCardWidth;
            int lineLenght = 0;
            if (firstLine.Length > secondLine.Length)
            {
                if (firstLine.Length > index.Length)
                {
                    lineLenght = firstLine.Length;
                }
                else
                {
                    lineLenght = index.Length;
                }
            }
            else
            {
                if (secondLine.Length > index.Length)
                {
                    lineLenght = secondLine.Length;
                }
                else
                {
                    lineLenght = index.Length;
                }
            }

            if (lineLenght + borderWidth * 2 > minCardWidth)
            {
                cardWidth = lineLenght + borderWidth * 2;
            }

            DrawBorder(borderSign, borderWidth, cardWidth);
            DrawLine(firstLine, borderSign, borderWidth, cardWidth);
            DrawLine(secondLine, borderSign, borderWidth, cardWidth);
            DrawLine(index, borderSign, borderWidth, cardWidth);
            DrawBorder(borderSign, borderWidth, cardWidth);
        }

        static void DrawBorder(string borderSign, int borderWidth, int cardWidth)
        {
            for (int i = 0; i < borderWidth; i++)
            {
                for (int j = 0; j < cardWidth; j++)
                {
                    Write(borderSign);
                }
                WriteLine();
            }
        }

        static void DrawLine(string line, string borderSign, int borderWidth, int cardWidth)
        {
            int right, left;
            (right, left) = calculatePading(line, borderWidth, cardWidth);
            DrawBorderPadding(borderSign, borderWidth);
            DrawPadding(right);
            Write(line);
            DrawPadding(left);
            DrawBorderPadding(borderSign, borderWidth);
            WriteLine();
        }
        
        static (int, int) calculatePading(string line, int borderWidth, int cardWidth)
        {
            int right, left;
            int difference = cardWidth - (line.Length + borderWidth * 2);
            if (difference % 2 == 0)
            {
                left = right = difference / 2;
            }
            else
            {
                difference -= 1;
                right = difference / 2;
                left = difference / 2 + 1;
            }

            return (right, left);
        }

        private static void DrawBorderPadding(string borderSign, int borderWidth)
        {
            for (int i = 0; i < borderWidth; i++)
            {
                Console.Write(borderSign);
            }
        }

        private static void DrawPadding(int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(" ");
            }
        }

    }
}
