using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DrinkGame
{
    public class Pilorium : Game
    {
        private int _pilorium;

        private static readonly KeyValuePair<string, int> I = new KeyValuePair<string, int>("PALITO", 1);
        private static readonly KeyValuePair<string, int> V = new KeyValuePair<string, int>("VE", 5);
        private static readonly KeyValuePair<string, int> X = new KeyValuePair<string, int>("EQUIS", 10);
        private static readonly KeyValuePair<string, int> L = new KeyValuePair<string, int>("ELE", 50);
        private static readonly KeyValuePair<string, int> C = new KeyValuePair<string, int>("CE", 100);
        private static readonly KeyValuePair<string, int> D = new KeyValuePair<string, int>("DE", 500);
        private static readonly KeyValuePair<string, int> M = new KeyValuePair<string, int>("EME", 1000);
        private static IDictionary<string, int> _romanNbrs;       
        
        public Pilorium(int pilorium)
        {
            _pilorium = pilorium;
            _romanNbrs = new Dictionary<string, int>();
            _romanNbrs.Add(I);
            _romanNbrs.Add(V);
            _romanNbrs.Add(X);
            _romanNbrs.Add(L);
            _romanNbrs.Add(C);
            _romanNbrs.Add(D);
            _romanNbrs.Add(M);
            _romanNbrs = _romanNbrs.OrderByDescending(nbr => nbr.Value)
                .ToDictionary(d => d.Key, x => x.Value);
        }

        public override void Play(int lim)
        {
            for (int i = 1; i < lim; i++)
            {
                var comparer = i;
                var toPrint = "";
                if (comparer%_pilorium == 0)
                {
                    Console.WriteLine("Pilorium");
                    continue;
                }

                foreach (var nbr in _romanNbrs)
                {
                    Assign:
                    
                    if (comparer - nbr.Value < 0 || 
                        ((nbr.Equals(V) || nbr.Equals(L) || nbr.Equals(D)) 
                        && toPrint.EndsWith(nbr.Key))) continue;
                    comparer -= nbr.Value;
                    _AddPrint(nbr, ref toPrint);
                    switch (comparer - nbr.Value)
                    {
                        case -1:
                            comparer -= 1;
                            _AddPrint(I, ref toPrint);
                            break;
                        case -5:
                            comparer -= 5;
                            _AddPrint(V, ref toPrint);
                            break;
                        case -10:
                            comparer -= 10;
                            _AddPrint(X, ref toPrint);
                            break;
                        case -50:
                            comparer -= 50;
                            _AddPrint(L, ref toPrint);
                            break;
                        case -100:
                            comparer -= 100;
                            _AddPrint(C, ref toPrint);
                            break;
                        case -500:
                            comparer -= 500;
                            _AddPrint(D, ref toPrint);
                            break;
                        case -1000:
                            comparer -= 1000;
                            _AddPrint(M, ref toPrint);
                            break;
                    }
                    goto Assign;

                }
                Console.WriteLine(toPrint);
            }
        }

        private void _AddPrint(KeyValuePair<string, int> letter, ref string toPrint)
        {
            toPrint += letter.Key + " ";
        }
    }
}
