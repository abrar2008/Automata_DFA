using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Configuration;

namespace DFA_Automata
{
    class DFA
    {

        public string[] allStates;
        string[] finalStatesTable;
        int totalFinalState;
        int totalState;
        string initialState;
        int totalSetNo;

        string[] allStringvalues;
        string[] allSetValues;
        string[,] table;
        public bool ans;

        public int remainingStatesValue = 0;

        public void TotalNumberOfState(int totalStates,string initialstate, int totalFinalStates)
        {
            allStates = new string[totalStates];
            allStates[0] = initialstate;
            finalStatesTable = new string[totalFinalStates];
            totalState = totalStates;
            totalFinalState = totalFinalStates;
            initialState = initialstate;
            remainingStatesValue = (totalStates - (totalFinalState + 1));

        }

        int m = 0;
        int pp = 0;

        public void FinalStates(string finalState)
        {
            
            finalStatesTable[pp] = finalState;
            if (totalFinalState == totalState)
            {
                allStates[m] = finalState;
                m++;
            }
            else
            {
                //////////////////////////////////////////

                if (finalStatesTable[pp] == allStates[0])
                {
                    m++;
                    remainingStatesValue = totalState - totalFinalState;

                }
                else
                {
                    if(m == 0)
                    {
                        m = 1;
                    }
                    else
                    { }

                    allStates[m] = finalState;
                    m++;
                }
                

                //if (finalStatesTable[m] != initialState)
                //{
                //    m++;
                //    allStates[m] = finalState;

                //}
                //else
                //{
                //    remainingStatesValue = totalState - totalFinalState;
                //    allStates[m] = finalState;

                //}
            }
            pp++;

        }
        
        public void remainingStatesValueInsert(string remainingStates)
        {

                allStates[m] = remainingStates;
            
            
            m++;
            //int c = (totalState - (totalFinalState + 1));
            //if (totalFinalState == 1 && check != c)
            //{
            //    allStates[p + 2] = remainingStates;
            //    check++;
            //}
            //else if (totalFinalState > 1)
            //{
            //    allStates[totalState - totalFinalState] = remainingStates;
            //    //count--;
            //}
            //p++;

        }


        public void totalsetOfStates(int totalsetNo)
        {
             allSetValues = new string[totalsetNo];
            totalSetNo = totalsetNo;
            table = new string[totalState, totalSetNo];
        }

        int n = 0;
        public void setOfStates(string setOfStatesNo)
        {
            
            allSetValues[n] = setOfStatesNo;
            n++;
        }



        public void sorting()
        {
            string temp;
            for (int i = 0; i < allStates.Length; i++)
            {
                for (int j = 0; j < allStates.Length - 1; j++)
                {
                    if (allStates[j].CompareTo(allStates[j + 1]) > 0)
                    {
                        temp = allStates[j];
                        allStates[j] = allStates[j + 1];
                        allStates[j + 1] = temp;
                    }
                }
            }

        }


        int j = 0;
        int k = 0;
        public void tableTrasationValue(string value)
        {
            if(k < totalSetNo)
            {
                table[j, k] = value;
                k++;
            }
            else
            {

                k = 0;
                j++;
                table[j, k] = value;
                k++;
            }
        }


        public void checkInput(string stringvalue)
        {
            allStringvalues = new string[stringvalue.Length];
            string Stringvalueposition;
            string automataPoposition;
            string currentPoposition;
            for (int x = 0; x < allStringvalues.Length; x++)
            {
                allStringvalues[x] = Convert.ToString(stringvalue[x]);
            }

            int p = 0;
            int stringCount = Convert.ToInt16(stringvalue.Length - 1);
            for (int x = 0; x < allStringvalues.Length; x++)
            {
                Stringvalueposition = allStringvalues[x];
                int nn = Convert.ToInt16(Stringvalueposition);

                automataPoposition = table[p, nn];
                for (int i = 0; i < totalFinalState; i++)
                {


                    if (automataPoposition == finalStatesTable[i] && x == stringCount)
                    {
                        ans = true;
                        break;
                    }
                    else
                    {
                        ans = false;
                        currentPoposition = automataPoposition;
                        for (int j = 0; j < totalState; j++)
                        {
                            if (currentPoposition == allStates[j])
                            {
                                p = j;
                            }
                        }
                    }
                }

            }





        }

        public void reSet()
        {

            string a = "";
            string[] allStates = new string[a.Length];
            string[] finalStatesTable = new string[a.Length];
            totalFinalState=0;
            totalState=0;
            initialState ="";
            totalSetNo=0;
            string[] allStringvalues = new string[a.Length];
            string[] allSetValues =  new string[a.Length]; ;
            string[,] table = new string[a.Length,a.Length];
            ans=false;
            remainingStatesValue = 0;
            m = 0;
            pp = 0;
            n = 0;
            j = 0;
            k = 0;

        }





    }
}
