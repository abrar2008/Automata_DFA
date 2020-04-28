using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DFA_Automata
{
    public partial class Form1 : Form
    {

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            panel3.Size = new Size(this.Width, this.Height);
        }

        public Form1()
        {
            InitializeComponent();
            StartProgram();          
        }

        DFA dfa = new DFA();
        int totalNumber = 0;
        int totalfinal = 0;
        TextBox[] txtNames;
        TextBox[] txtNames1;
        TextBox[] txtNames2;
        TextBox[] txtNames3;
        int totalSetOfStatesNo = 0;
        int count = 0;



        private void btn_numberOfState_Click(object sender, EventArgs e)
        {
            dfa.reSet();
            if (totalNumber >= totalfinal && txt_InitialState.Text!="" && txt_totalFinalState.Text != "" && txt_totalNumberOfState.Text != "")
            {
                label8.Visible = true;
                btn_numberOfState.Visible = false;
                btn_insertFinalState.Visible = true;
                panel3.Visible = true;
                panel7.Visible = true;

                dfa.TotalNumberOfState(Convert.ToInt32(txt_totalNumberOfState.Text), txt_InitialState.Text, Convert.ToInt32(txt_totalFinalState.Text));
                totalNumber = Convert.ToInt32(txt_totalNumberOfState.Text);
                totalfinal = Convert.ToInt32(txt_totalFinalState.Text);
                createFinalTextBox(Convert.ToInt32(txt_totalFinalState.Text));
                
            }
            else
            {
                MessageBox.Show("Pleases Fill all TextBox", "window title", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public void createFinalTextBox(int num)
        {
            
            txtNames = new TextBox[num];
            int pointX = 250;
            int pointY = 280;
            int pointX1 = 380;
            int pointY1 = 280;
        
            for (int i = 0; i < num; i++)
            {
                txtNames[i] = new TextBox();
                if (i % 2 == 0)
                {
                    txtNames[i].Location = new Point(pointX, pointY);
                    txtNames[i].Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold);
                    pointY += 30;
        
                }
                else
                {
                    txtNames[i].Location = new Point(pointX1, pointY1);
                    txtNames[i].Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold);
                    pointY1 += 30;
                }
                txtNames[i].Height = 150;
                txtNames[i].Width = 110;

                this.Controls.Add(txtNames[i]);
                this.Show();
            }

            //try
            //{
            //int a = this.Height;
            //int aa = a - 10;
            //panel7.Size = new Size(10, aa);

            //}
            //catch (FormatException e)
            //{

            //    MessageBox.Show(Convert.ToString(e));
            //}
        }

        private void btn_insertFinalState_Click(object sender, EventArgs e)
        {
            label7.Visible = true;
            btn_insertFinalState.Visible = false;
            btn_next.Visible = true;

            string input = "";
            for (int i = 0; i < totalfinal; i++)
            {

                input = Convert.ToString(txtNames[i].Text);
                dfa.FinalStates(input);
            }
             int num =dfa.remainingStatesValue;
            createRemainingTextBox(num);

        }
        int n = 0;
        public void createRemainingTextBox(int number)
        {
            n = number;
            txtNames1 = new TextBox[number];

            int pointX = 10;
            int pointY = 280;
            int pointX1 = 120;
            int pointY1 = 280;

            for (int i = 0; i < number; i++)
            {
                txtNames1[i] = new TextBox();
                if (i % 2 == 0)
                {
                    txtNames1[i].Location = new Point(pointX, pointY);
                    txtNames1[i].Font = new Font("Microsoft Sans Serif", 10f,FontStyle.Bold);
                    pointY += 30;
                }
                else
                {
                    txtNames1[i].Location = new Point(pointX1, pointY1);
                    txtNames1[i].Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold);
                    pointY1 += 30;
                }
                txtNames1[i].Height = 150;

                this.Controls.Add(txtNames1[i]);
                this.Show();
            }


            ////////////////////////////////////////////////////////////
            //int a = this.Height;
            //int aa = a - 10;
            //panel3.Size = new Size(10,aa);

            ////////////////////////////////////////////////////////////

        }   

        private void btn_next_Click(object sender, EventArgs e)
        {
            btn_next.Visible = false;
            label2.Visible = true;
            txt_totalNumberOfSetOfState.Visible = true;
            btn_SetOfState.Visible = true;
            panel8.Visible = true;

            int nn = totalfinal;
            string input = "";
            for (int i = 0; i < n; i++)
            {

                input = Convert.ToString(txtNames1[i].Text);
                dfa.remainingStatesValueInsert(input);
                nn++;
            }

        }

        
        private void btn_SetOfState_Click(object sender, EventArgs e)
        {
            btn_SetOfState.Visible = false;
            insertSetOfState.Visible = true;
            panel8.Visible = true;
            totalSetOfStatesNo = Convert.ToInt32(txt_totalNumberOfSetOfState.Text);
            createSetOfStateTextBox(totalSetOfStatesNo);
        }

        public void createSetOfStateTextBox(int number)
        {
            txtNames2 = new TextBox[number];

            int pointX = 520;
            int pointY = 240;
            int pointX1 = 640;
            int pointY1 = 240;

            for (int i = 0; i < number; i++)
            {
                txtNames2[i] = new TextBox();
                if (i % 2 == 0)
                {
                    txtNames2[i].Location = new Point(pointX, pointY);
                    txtNames2[i].Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold);
                    pointY += 30;
                }
                else
                {
                    txtNames2[i].Location = new Point(pointX1, pointY1);
                    txtNames2[i].Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold);
                    pointY1 += 30;
                }
                txtNames2[i].Height = 150;

                this.Controls.Add(txtNames2[i]);
                this.Show();
            }


        }

        private void insertSetOfState_Click(object sender, EventArgs e)
        {
            txt_stringInput.Visible = true;
            label3.Visible = true;
            btn_checkInput.Visible = true;
            
            string[] val = new string[totalSetOfStatesNo];
            dfa.totalsetOfStates(totalSetOfStatesNo);
            string input = "";
            for (int i = 0; i < totalSetOfStatesNo; i++)
            {

                input = Convert.ToString(txtNames2[i].Text);
                dfa.setOfStates(input);
                val[i] = input;
            }

            int pointX = 790;
            int pointY = 280;
            int pointX1 = 830;
            int pointY1 = 280;

            for (int i = 0; i < totalSetOfStatesNo; i++)
            {
                TextBox a = new TextBox();

                if (i == 0)
                {

                    a.Text = val[i].ToString();
                    a.Location = new Point(pointX, pointY);
                    txtNames2[i].Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold);
                    this.Controls.Add(a);
                    this.Show();
                    pointY += 38;
                }
                else
                {

                    a.Text = val[i].ToString();
                    a.Location = new Point(pointX1, pointY1);
                    txtNames2[i].Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold);
                    this.Controls.Add(a);
                    this.Show();
                    pointY1 = 130;
                    pointX1 += 38;

                }

                a.Width = 30;
                
            }

            dfa.sorting();
            trasationTableTextBox();
        }

        public void trasationTableTextBox()
        {
            int number = ((totalNumber * totalSetOfStatesNo)+ totalNumber);
            int n = 1+totalSetOfStatesNo;
            txtNames3 = new TextBox[number];

            string[] val = new string[totalNumber];
            string input = "";
            for (int i = 0; i < totalNumber; i++)
            {
                string a = dfa.allStates[i];
                input = Convert.ToString(a.ToString());
                val[i] = input;
            }



            int pointX = 760;
            int pointY = 330;
            int pointX1 = 795;
            int pointY1 = 330;

            int c = 0;
            bool condition = false;
            int c1 = 0;
            int nn = 0;
            for (int i = 0; i < number; i++)
            {

                txtNames3[i] = new TextBox();
                if (c % n==0)
                {
                    txtNames3[i].Text = val[nn].ToString();
                    txtNames3[i].Location = new Point(pointX, pointY);
                    txtNames3[i].Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold);
                    pointY += 30;
                    condition = true;
                    nn++;
                }
                else
                {
                    txtNames3[i].Location = new Point(pointX1, pointY1);
                    txtNames3[i].Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold);
                   // pointY1 = 180;
                    pointX1 += 38;
                    condition = false;
                    c1++;
                }
                txtNames3[i].Width = 30;
                this.Controls.Add(txtNames3[i]);
                this.Show();

                c++;
                if(condition == true && c1>0)
                {
                    pointX1 = 795;
                    pointY1 += 30;
                   // pointX1 += 38;
                }
            }


        }

        private void btn_checkInput_Click(object sender, EventArgs e)
        {

            if(count == 0)
            {
                getTableValue();
                dfa.checkInput(Convert.ToString(txt_stringInput.Text));
                btn_reSet.Visible = true;
                count++;
                btn_checkInput.Text = "Try Another String";

            }
            else
            {
            

                dfa.checkInput(Convert.ToString(txt_stringInput.Text));
            }
            bool an = dfa.ans;
            if (an == true)
            {
                label9.Text = "True";
            }
            else
            {
                label9.Text = "False";
            }
            label9.Visible = true;
        }


        public void getTableValue()
        {
            int number = ((totalNumber * totalSetOfStatesNo) + totalNumber);
            int n = 1 + totalSetOfStatesNo;

            string[] val = new string[totalSetOfStatesNo];
            int cc = 0;
            string input = "";
            for (int i = 0; i < number; i++)
            {
                if (cc % n == 0)
                {

                }
                else
                {
                    input = Convert.ToString(txtNames3[i].Text);
                    dfa.tableTrasationValue(input);
                    //val[i] = input;

                }
                cc++;
            }
        }

        private void btn_reSet_Click(object sender, EventArgs e)
        {
            //Form1 f = new Form1();
            this.Controls.Clear();
            this.InitializeComponent();
            StartProgram();

        }

        public void StartProgram()
        {
            label9.Text="true";
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            btn_insertFinalState.Visible = false;
            panel3.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            txt_totalNumberOfSetOfState.Visible = false;
            btn_SetOfState.Visible = false;
            btn_next.Visible = false;
            insertSetOfState.Visible = false;
            label2.Visible = false;
            txt_stringInput.Visible = false;
            label3.Visible = false;
            btn_checkInput.Visible = false;
            btn_reSet.Visible = false;

            DFA dfa = new DFA();
            totalNumber = 0;
            totalfinal = 0;
            totalSetOfStatesNo = 0;
            count = 0;
            n = 0;
            dfa.reSet();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}



