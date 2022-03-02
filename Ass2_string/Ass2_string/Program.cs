using System;
using System.Collections;
using System.Linq;
using System.Text.RegularExpressions;

namespace Ass2_string
{
    public class Program
    {
        public static void Main(string[] args)

        {
            while (true)
            {
                Console.WriteLine("\n\tMenu");
                Console.WriteLine("\nPress 1 for no of Blank Space in the string");
                Console.WriteLine("Press 2 for no of words in string");
                Console.WriteLine("Press 3 for no of '.' in string");
                Console.WriteLine("Press 4 for no of statments in the string");
                Console.WriteLine("Press 5 for no of digits in the string");
                Console.WriteLine("Press 6 for no of vowels in the string");
                Console.WriteLine("Press 7 for no of 'the','is','to'and their position in the string");
                Console.WriteLine("Press 8 for no and position of comma','");
                Console.WriteLine("Press 9 for reverse of each word in string");
                Console.WriteLine("Press 10 for reverse entire string");
                Console.WriteLine("Press 11 for each statement in seperate line");
                Console.WriteLine("Press 12 for Print all words decorated uasing e.g. \"Live and Let Die\"");
                Console.WriteLine("Press 13 for Convert first character of each word in upper case.");
                Console.WriteLine("Press 14 for List 'month names' from the above list e.g. January, February, etc.");
                Console.WriteLine("Press 15 to Exit");
                Console.WriteLine();
                Console.WriteLine("Enter your choice");
                int choose = Convert.ToInt32(Console.ReadLine());

                string str = "James Bond is a fictional character created by novelist Ian Fleming in 1953. A British secret agent working for MI6 under the codename 007, he has been portrayed on film by actors Sean Connery, David Niven, George Lazenby, Roger Moore, Timothy Dalton, Pierce Brosnan and Daniel Craig in twenty-seven productions. All but two films were made by Eon Productions, which now holds the adaptation rights to all of Fleming's Bond novels.[1][2]n 1961, producers Albert R.Broccoli and Harry Saltzman purchased the filming rights to Fleming's novels.[3] They founded Eon Productions and, with financial backing by United Artists, produced Dr. No, directed by Terence Young and featuring Connery as Bond.[4] Following its release in 1962, Broccoli and Saltzman created the holding company Danjaq to ensure future productions in the James Bond film series.[5] The series currently has twenty-five films, with the most recent, No Time to Die, released in September 2021. With a combined gross of nearly $7 billion to date, it is the fifth-highest-grossing film series.[6] Accounting for inflation, it has earned over $14 billion at current prices.[a] The films have won five Academy Awards: for Sound Effects (now Sound Editing) in Goldfinger (at the 37th Awards), to John Stears for Visual Effects in Thunderball (at the 38th Awards), to Per Hallberg and Karen Baker Landers for Sound Editing, to Adele and Paul Epworth for Original Song in Skyfall (at the 85th Awards) and to Sam Smith and Jimmy Napes for Original Song in Spectre (at the 88th Awards). Several of the songs produced for the films have been nominated for Academy Awards for Original Song, including Paul McCartney's \"Live and let Die\",Carly Simon's \"Nobody Does It Better\" and Sheena Easton's \"For Your Eyes Only\".In 1982 Albert R. Broccoli received the Irving G.Thalberg Memorial Award.[8]";

                switch (choose)
                {
                    case 1:

                        CountSpace();
                        break;

                    case 2:
                        string[] result = str.Split(new char[] { ',', ' ', '.' });
                        int coutOfWord = 0;
                        for (int i = 0; i < result.Length; i++)
                        {

                            coutOfWord++;
                        }
                        Console.WriteLine("no of words: {0}", coutOfWord);

                        break;

                    case 3:
                       
                        CountOFdotsLines(str);
                        break;

                    case 4:
                        CountOFdotsLines(str);
                        break;

                    case 5:
                        int noOfDigit = 0;
                        for (int i = 0; i < str.Length; i++)
                        {


                            if (str[i] >= '0' && str[i] <= '9')
                            {
                                noOfDigit++;
                            }
                        }
                        Console.WriteLine("No of digits {0}", noOfDigit);
                        break;

                    case 6:
                        int CountOfVowels = 0;
                        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'O', 'U' };


                        for (int i = 0; i < str.Length; i++)
                        {
                            if (vowels.Contains(str[i]))
                            {
                                CountOfVowels++;
                            }
                        }
                        Console.WriteLine("No of vowels resent:{0}", CountOfVowels);
                        break;

                    case 7:
                        int count = 0;
                        string[] words = { "the", "is", "to", "and" };
                        ArrayList index = new ArrayList();
                        foreach (string word in words)
                        {
                            for (int i = str.IndexOf(word); i >= 0; i = str.IndexOf(word, i + 1))
                            {
                                count++;
                                index.Add(i);
                            }
                            Console.WriteLine($"count of '{word}'in string '{count}'");
                            foreach (int ele in index)
                            {
                                Console.WriteLine(ele);
                            }
                            index.Clear();
                        }

                        break;



                    case 8:
                        char[] textarray = str.ToCharArray();
                        int noOfCommas = 0;

                        for (int i = 0; i < textarray.Length; i++)
                        {
                            if (textarray[i] == ',')
                            {

                                Console.WriteLine("the indexs :{0}", i);
                                noOfCommas++;


                            }
                        }
                        Console.WriteLine("No of commas {0}", noOfCommas);
                        break;

                    case 9:
                        string reverse = string.Empty;
                        int length = str.Length - 1;
                        while (length >= 0)
                        {
                            reverse = reverse + str[length];
                            length--;
                        }
                        Console.WriteLine($"reverse string is {reverse}");

                        break;

                    case 10:

                        string rev = String.Empty;
                        for (int i = str.Length - 1; i >= 0; i--)
                        {
                            rev += str[i];
                        }
                        Console.WriteLine(rev);
                        break;

                    case 11:
                        string output = str.Replace(".", Environment.NewLine);
                        Console.WriteLine(output);
                        break;

                    case 12:
                        var reg = new Regex("\".*?\"");
                        var matches = reg.Matches(str);
                        foreach (var item in matches)
                        {
                            Console.WriteLine(item.ToString());
                        }
                        break;




                    case 13:
                        char[] arr = str.ToCharArray();
                        for (int i = 1; i < arr.Length; i++)
                        {
                            if (arr[i - 1] == ' ' && char.IsLower(arr[i]))
                            {
                                arr[i] = char.ToUpper(arr[i]);

                            }
                        }
                        Console.WriteLine(arr);
                        break;


                    case 14:

                        string[] months = { "Janurary", "Feburary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
                        foreach (string month in months)
                        {
                            if (str.Contains(month))
                            {
                                Console.WriteLine("The month in this string has :{0}", month);
                            }
                        }
                        break;
                    case 15:
                        System.Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again");
                        break;





                }




                void CountSpace()
                {
                    int Count = 0;
                    string str2;
                    char[] textarray = str.ToCharArray();

                    for (int i = 0; i < str.Length; i++)
                    {
                        str2 = str.Substring(i, 1);
                        if (str2 == " ")
                        {

                            Count++;
                        }


                    }
                    Console.WriteLine(Count);


                }


                void CountOFdotsLines(string str)
                {
                   int a = 0;
                  
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (str[i] == '.')
                            a++;
                           
                        
                    }
                    Console.WriteLine("a");
                   
                    
                    
                }
                static void statementFullstop(string str)
                {
                    int Fullstop = 0;
                    foreach (char c in str)
                    {
                        if (c == '.')
                        {
                            Fullstop++;
                        }
                    }
                    Console.WriteLine($"Total number of fullstops/Statements are:{Fullstop}");
                }










            }






        }
    }   
}





           
