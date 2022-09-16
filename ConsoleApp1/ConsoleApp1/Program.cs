using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace stelselOplosser
{
    class program
    {
        static void Main()
        {
            var ul = " ";
            var um = " ";
            var ur = " ";
            var ml = " ";
            var mr = " ";
            var mm = " ";
            var ll = " ";
            var lm = " ";
            var lr = " ";
            Random rnd = new Random();
            bool pc = false;


            bool placementcorrect = false;
            Console.WriteLine("let's play tic tac toe");
            Console.WriteLine("do you wanna play against pc");
            if (Console.ReadLine() == "yes")
            {
                pc = true;
            }
            while (true)
            {
                while (placementcorrect == false)
                {
                    var placement = " ";
                    Console.WriteLine("place the x in a spot (ul,um,ur,ml,mm,mr,ll,lm,lr)");
                    placement = Console.ReadLine();
                    placementcorrect = false;
                    if (placement == "ul")
                    {
                        if (ul == " ")
                        {
                            ul = "x";
                            placementcorrect = true;
                        }
                        else
                        {
                            Console.WriteLine("this place is already taken");
                        }
                    }
                    else if (placement == "um")
                    {
                        if (um == " ")
                        {
                            um = "x";
                            placementcorrect = true;
                        }
                        else
                        {
                            Console.WriteLine("this place is already taken");
                        }
                    }
                    else if (placement == "ur")
                    {
                        if (ur == " ")
                        {
                            ur = "x";
                            placementcorrect = true;
                        }
                        else
                        {
                            Console.WriteLine("this place is already taken");
                        }
                    }
                    else if (placement == "ml")
                    {
                        if (ml == " ")
                        {
                            ml = "x";
                            placementcorrect = true;
                        }
                        else
                        {
                            Console.WriteLine("this place is already taken");
                        }
                    }
                    else if (placement == "mm")
                    {
                        if (mm == " ")
                        {
                            mm = "x";
                            placementcorrect = true;
                        }
                        else
                        {
                            Console.WriteLine("this place is already taken");
                        }
                    }
                    else if (placement == "mr")
                    {
                        if (mr == " ")
                        {
                            mr = "x";
                            placementcorrect = true;
                        }
                        else
                        {
                            Console.WriteLine("this place is already taken");
                        }
                    }
                    else if (placement == "ll")
                    {
                        if (ll == " ")
                        {
                            ll = "x";
                            placementcorrect = true;
                        }
                        else
                        {
                            Console.WriteLine("this place is already taken");
                        }
                    }
                    else if (placement == "lm")
                    {
                        if (lm == " ")
                        {
                            lm = "x";
                            placementcorrect = true;
                        }
                        else
                        {
                            Console.WriteLine("this place is already taken");
                        }
                    }
                    else if (placement == "lr")
                    {
                        if (lr == " ")
                        {
                            lr = "x";
                            placementcorrect = true;
                        }
                        else
                        {
                            Console.WriteLine("this place is already taken");
                        }
                    }
                    else
                    {
                        Console.WriteLine("the placement was incorrect pleasse try again");
                    }
                }
                placementcorrect = false;
                Console.WriteLine(ul + um + ur);
                Console.WriteLine(ml + mm + mr);
                Console.WriteLine(ll + lm + lr);
                if (ul == um & ul == ur & ul != " ")
                {
                    Console.WriteLine("the winner is " + ul);
                    break;
                }
                else if (ml == mm & mr == mm & ml != " ")
                {
                    Console.WriteLine("the winner is " + mm);
                    break;
                }
                else if (ll == lm & lr == lm & ll != " ")
                {
                    Console.WriteLine("the winner is " + ll);
                    break;
                }
                else if (ul == ml & ml == ll & ul != " ")
                {
                    Console.WriteLine("the winner is " + ul);
                    break;
                }
                else if (um == mm & mm == lm & um != " ")
                {
                    Console.WriteLine("the winner is " + um);
                    break;
                }
                else if (ur == mr & mr == lr & ur != " ")
                {
                    Console.WriteLine("the winner is " + ur);
                    break;
                }
                else if (ul == mm & mm == lr & ul != " ")
                {
                    Console.WriteLine("the winner is " + ul);
                    break;
                }
                else if (ll == mm & mm == ur & ll != " ")
                {
                    Console.WriteLine("the winner is " + ll);
                    break;
                }
                if (pc == false)
                {
                    placementcorrect = false;
                    while (placementcorrect == false)
                    {
                        Console.WriteLine("place the o in a spot (ul,um,ur,ml,mm,mr,ll,lm,lr)");
                        var placement2 = Console.ReadLine();
                        if (placement2 == "ul")
                        {
                            if (ul == " ")
                            {
                                ul = "o";
                                placementcorrect = true;
                            }
                            else
                            {
                                Console.WriteLine("this place is already taken");
                            }
                        }
                        else if (placement2 == "um")
                        {
                            if (um == " ")
                            {
                                um = "o";
                                placementcorrect = true;
                            }
                            else
                            {
                                Console.WriteLine("this place is already taken");
                            }
                        }
                        else if (placement2 == "ur")
                        {
                            if (ur == " ")
                            {
                                ur = "o";
                                placementcorrect = true;
                            }
                            else
                            {
                                Console.WriteLine("this place is already taken");
                            }
                        }
                        else if (placement2 == "ml")
                        {
                            if (ml == " ")
                            {
                                ml = "o";
                                placementcorrect = true;
                            }
                            else
                            {
                                Console.WriteLine("this place is already taken");
                            }
                        }
                        else if (placement2 == "mm")
                        {
                            if (mm == " ")
                            {
                                mm = "o";
                                placementcorrect = true;
                            }
                            else
                            {
                                Console.WriteLine("this place is already taken");
                            }
                        }
                        else if (placement2 == "mr")
                        {
                            if (mr == " ")
                            {
                                mr = "o";
                                placementcorrect = true;
                            }
                            else
                            {
                                Console.WriteLine("this place is already taken");
                            }
                        }
                        else if (placement2 == "ll")
                        {
                            if (ll == " ")
                            {
                                ll = "o";
                                placementcorrect = true;
                            }
                            else
                            {
                                Console.WriteLine("this place is already taken");
                            }
                        }
                        else if (placement2 == "lm")
                        {
                            if (lm == " ")
                            {
                                lm = "o";
                                placementcorrect = true;
                            }
                            else
                            {
                                Console.WriteLine("this place is already taken");
                            }
                        }
                        else if (placement2 == "lr")
                        {
                            if (lr == " ")
                            {
                                lr = "o";
                                placementcorrect = true;
                            }
                            else
                            {
                                Console.WriteLine("this place is already taken");
                            }
                        }
                        else
                        {
                            Console.WriteLine("the placement was incorrect pleasse try again");
                        }
                    }
                }
                else
                {
                    placementcorrect = false;
                    while (placementcorrect == false)
                    {
                        int pcmove = rnd.Next(1, 10);
                        if (pcmove == 1)
                        {
                            if (ul == " ")
                            {
                                ul = "o";
                                placementcorrect = true;
                            }
                            else
                            {
                                Console.WriteLine("this place is already taken");
                            }
                        }
                        else if (pcmove == 2)
                        {
                            if (um == " ")
                            {
                                um = "o";
                                placementcorrect = true;
                            }
                            else
                            {
                                Console.WriteLine("this place is already taken");
                            }
                        }
                        else if (pcmove == 3)
                        {
                            if (ur == " ")
                            {
                                ur = "o";
                                placementcorrect = true;
                            }
                            else
                            {
                                Console.WriteLine("this place is already taken");
                            }
                        }
                        else if (pcmove == 4)
                        {
                            if (ml == " ")
                            {
                                ml = "o";
                                placementcorrect = true;
                            }
                            else
                            {
                                Console.WriteLine("this place is already taken");
                            }
                        }
                        else if (pcmove == 5)
                        {
                            if (mm == " ")
                            {
                                mm = "o";
                                placementcorrect = true;
                            }
                            else
                            {
                                Console.WriteLine("this place is already taken");
                            }
                        }
                        else if (pcmove == 6)
                        {
                            if (mr == " ")
                            {
                                mr = "o";
                                placementcorrect = true;
                            }
                            else
                            {
                                Console.WriteLine("this place is already taken");
                            }
                        }
                        else if (pcmove == 7)
                        {
                            if (ll == " ")
                            {
                                ll = "o";
                                placementcorrect = true;
                            }
                            else
                            {
                                Console.WriteLine("this place is already taken");
                            }
                        }
                        else if (pcmove == 8)
                        {
                            if (lm == " ")
                            {
                                lm = "o";
                                placementcorrect = true;
                            }
                            else
                            {
                                Console.WriteLine("this place is already taken");
                            }
                        }
                        else if (pcmove == 9)
                        {
                            if (lr == " ")
                            {
                                lr = "o";
                                placementcorrect = true;
                            }
                            else
                            {
                                Console.WriteLine("this place is already taken");
                            }
                        }
                        else
                        {
                            Console.WriteLine("the placement was incorrect pleasse try again");
                        }
                    }
                }
                Console.WriteLine(ul + um + ur);
                Console.WriteLine(ml + mm + mr);
                Console.WriteLine(ll + lm + lr);
                placementcorrect = false;
                if (ul == um & ul == ur & ul != " ")
                {
                    Console.WriteLine("the winner is " + ul);
                    break;
                }
                else if (ml == mm & mr == mm & ml != " ")
                {
                    Console.WriteLine("the winner is " + mm);
                    break;
                }
                else if (ll == lm & lr == lm & ll != " ")
                {
                    Console.WriteLine("the winner is " + ll);
                    break;
                }
                else if (ul == ml & ml == ll & ul != " ")
                {
                    Console.WriteLine("the winner is " + ul);
                    break;
                }
                else if (um == mm & mm == lm & um != " ")
                {
                    Console.WriteLine("the winner is " + um);
                    break;
                }
                else if (ur == mr & mr == lr & ur != " ")
                {
                    Console.WriteLine("the winner is " + ur);
                    break;
                }
                else if (ul == mm & mm == lr & ul != " ")
                {
                    Console.WriteLine("the winner is " + ul);
                    break;
                }
                else if (ll == mm & mm == ur & ll != " ")
                {
                    Console.WriteLine("the winner is " + ll);
                    break;
                }
            }
            Console.ReadKey();


        }
    }
}


