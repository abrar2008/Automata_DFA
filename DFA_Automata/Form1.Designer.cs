namespace DFA_Automata
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_numberOfState = new System.Windows.Forms.Button();
            this.txt_totalNumberOfState = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_InitialState = new System.Windows.Forms.TextBox();
            this.lbl_initialState = new System.Windows.Forms.Label();
            this.txt_totalFinalState = new System.Windows.Forms.TextBox();
            this.lbl_finalState = new System.Windows.Forms.Label();
            this.btn_insertFinalState = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_next = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_totalNumberOfSetOfState = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_SetOfState = new System.Windows.Forms.Button();
            this.insertSetOfState = new System.Windows.Forms.Button();
            this.txt_stringInput = new System.Windows.Forms.TextBox();
            this.btn_checkInput = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_reSet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_numberOfState
            // 
            this.btn_numberOfState.BackColor = System.Drawing.Color.LightGray;
            this.btn_numberOfState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_numberOfState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_numberOfState.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_numberOfState.Location = new System.Drawing.Point(45, 193);
            this.btn_numberOfState.Name = "btn_numberOfState";
            this.btn_numberOfState.Size = new System.Drawing.Size(134, 37);
            this.btn_numberOfState.TabIndex = 4;
            this.btn_numberOfState.Text = "Click me";
            this.btn_numberOfState.UseVisualStyleBackColor = false;
            this.btn_numberOfState.Click += new System.EventHandler(this.btn_numberOfState_Click);
            // 
            // txt_totalNumberOfState
            // 
            this.txt_totalNumberOfState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalNumberOfState.Location = new System.Drawing.Point(166, 114);
            this.txt_totalNumberOfState.Name = "txt_totalNumberOfState";
            this.txt_totalNumberOfState.Size = new System.Drawing.Size(59, 22);
            this.txt_totalNumberOfState.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Number Of States";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel1.Location = new System.Drawing.Point(230, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 93);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1298, 88);
            this.panel2.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Maroon;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1265, -1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 26);
            this.button3.TabIndex = 116;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Calligraphy", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(591, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(317, 83);
            this.label5.TabIndex = 115;
            this.label5.Text = "Automa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Calligraphy", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(439, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 83);
            this.label4.TabIndex = 114;
            this.label4.Text = "Dfa";
            // 
            // txt_InitialState
            // 
            this.txt_InitialState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_InitialState.Location = new System.Drawing.Point(166, 149);
            this.txt_InitialState.Name = "txt_InitialState";
            this.txt_InitialState.Size = new System.Drawing.Size(59, 22);
            this.txt_InitialState.TabIndex = 2;
            // 
            // lbl_initialState
            // 
            this.lbl_initialState.AutoSize = true;
            this.lbl_initialState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_initialState.Location = new System.Drawing.Point(0, 148);
            this.lbl_initialState.Name = "lbl_initialState";
            this.lbl_initialState.Size = new System.Drawing.Size(85, 16);
            this.lbl_initialState.TabIndex = 2;
            this.lbl_initialState.Text = "Initial State";
            // 
            // txt_totalFinalState
            // 
            this.txt_totalFinalState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalFinalState.Location = new System.Drawing.Point(443, 114);
            this.txt_totalFinalState.Name = "txt_totalFinalState";
            this.txt_totalFinalState.Size = new System.Drawing.Size(59, 22);
            this.txt_totalFinalState.TabIndex = 3;
            // 
            // lbl_finalState
            // 
            this.lbl_finalState.AutoSize = true;
            this.lbl_finalState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_finalState.Location = new System.Drawing.Point(238, 116);
            this.lbl_finalState.Name = "lbl_finalState";
            this.lbl_finalState.Size = new System.Drawing.Size(207, 16);
            this.lbl_finalState.TabIndex = 2;
            this.lbl_finalState.Text = "Total Number Of Final States";
            // 
            // btn_insertFinalState
            // 
            this.btn_insertFinalState.BackColor = System.Drawing.Color.LightGray;
            this.btn_insertFinalState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insertFinalState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insertFinalState.Location = new System.Drawing.Point(354, 174);
            this.btn_insertFinalState.Name = "btn_insertFinalState";
            this.btn_insertFinalState.Size = new System.Drawing.Size(134, 37);
            this.btn_insertFinalState.TabIndex = 100;
            this.btn_insertFinalState.Text = "Click me";
            this.btn_insertFinalState.UseVisualStyleBackColor = false;
            this.btn_insertFinalState.Click += new System.EventHandler(this.btn_insertFinalState_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel3.Location = new System.Drawing.Point(230, 231);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 346);
            this.panel3.TabIndex = 3;
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.LightGray;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.Location = new System.Drawing.Point(336, 174);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(134, 37);
            this.btn_next.TabIndex = 101;
            this.btn_next.Text = "Enter";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel4.Location = new System.Drawing.Point(505, 101);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 93);
            this.panel4.TabIndex = 102;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(515, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 15);
            this.label2.TabIndex = 105;
            this.label2.Text = "Total Number Of Set Of States";
            // 
            // txt_totalNumberOfSetOfState
            // 
            this.txt_totalNumberOfSetOfState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalNumberOfSetOfState.Location = new System.Drawing.Point(714, 113);
            this.txt_totalNumberOfSetOfState.Name = "txt_totalNumberOfSetOfState";
            this.txt_totalNumberOfSetOfState.Size = new System.Drawing.Size(30, 22);
            this.txt_totalNumberOfSetOfState.TabIndex = 104;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel7.Location = new System.Drawing.Point(505, 231);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 346);
            this.panel7.TabIndex = 103;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel8.Location = new System.Drawing.Point(747, 101);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 476);
            this.panel8.TabIndex = 107;
            // 
            // btn_SetOfState
            // 
            this.btn_SetOfState.BackColor = System.Drawing.Color.LightGray;
            this.btn_SetOfState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SetOfState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SetOfState.Location = new System.Drawing.Point(607, 174);
            this.btn_SetOfState.Name = "btn_SetOfState";
            this.btn_SetOfState.Size = new System.Drawing.Size(134, 37);
            this.btn_SetOfState.TabIndex = 108;
            this.btn_SetOfState.Text = "Click me";
            this.btn_SetOfState.UseVisualStyleBackColor = false;
            this.btn_SetOfState.Click += new System.EventHandler(this.btn_SetOfState_Click);
            // 
            // insertSetOfState
            // 
            this.insertSetOfState.BackColor = System.Drawing.Color.LightGray;
            this.insertSetOfState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertSetOfState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertSetOfState.Location = new System.Drawing.Point(591, 174);
            this.insertSetOfState.Name = "insertSetOfState";
            this.insertSetOfState.Size = new System.Drawing.Size(134, 37);
            this.insertSetOfState.TabIndex = 109;
            this.insertSetOfState.Text = "Enter";
            this.insertSetOfState.UseVisualStyleBackColor = false;
            this.insertSetOfState.Click += new System.EventHandler(this.insertSetOfState_Click);
            // 
            // txt_stringInput
            // 
            this.txt_stringInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stringInput.Location = new System.Drawing.Point(969, 437);
            this.txt_stringInput.Multiline = true;
            this.txt_stringInput.Name = "txt_stringInput";
            this.txt_stringInput.Size = new System.Drawing.Size(216, 35);
            this.txt_stringInput.TabIndex = 110;
            // 
            // btn_checkInput
            // 
            this.btn_checkInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_checkInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_checkInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checkInput.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_checkInput.Location = new System.Drawing.Point(861, 531);
            this.btn_checkInput.Name = "btn_checkInput";
            this.btn_checkInput.Size = new System.Drawing.Size(180, 37);
            this.btn_checkInput.TabIndex = 111;
            this.btn_checkInput.Text = "Check String";
            this.btn_checkInput.UseVisualStyleBackColor = false;
            this.btn_checkInput.Click += new System.EventHandler(this.btn_checkInput_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(830, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 112;
            this.label3.Text = "String Value";
            // 
            // btn_reSet
            // 
            this.btn_reSet.BackColor = System.Drawing.Color.LightGray;
            this.btn_reSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reSet.Location = new System.Drawing.Point(1102, 531);
            this.btn_reSet.Name = "btn_reSet";
            this.btn_reSet.Size = new System.Drawing.Size(172, 37);
            this.btn_reSet.TabIndex = 113;
            this.btn_reSet.Text = "Try Anothe Automata";
            this.btn_reSet.UseVisualStyleBackColor = false;
            this.btn_reSet.Click += new System.EventHandler(this.btn_reSet_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1009, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 25);
            this.label6.TabIndex = 114;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 16);
            this.label7.TabIndex = 115;
            this.label7.Text = "Remaining states values";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(250, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 16);
            this.label8.TabIndex = 115;
            this.label8.Text = "Final states values";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1047, 567);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 24);
            this.label9.TabIndex = 116;
            this.label9.Text = "label9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1300, 600);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_reSet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_checkInput);
            this.Controls.Add(this.txt_stringInput);
            this.Controls.Add(this.insertSetOfState);
            this.Controls.Add(this.btn_SetOfState);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_totalNumberOfSetOfState);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_insertFinalState);
            this.Controls.Add(this.txt_totalFinalState);
            this.Controls.Add(this.txt_InitialState);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_initialState);
            this.Controls.Add(this.lbl_finalState);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_totalNumberOfState);
            this.Controls.Add(this.btn_numberOfState);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DFA_automata";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_numberOfState;
        private System.Windows.Forms.TextBox txt_totalNumberOfState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_InitialState;
        private System.Windows.Forms.Label lbl_initialState;
        private System.Windows.Forms.TextBox txt_totalFinalState;
        private System.Windows.Forms.Label lbl_finalState;
        private System.Windows.Forms.Button btn_insertFinalState;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_totalNumberOfSetOfState;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btn_SetOfState;
        private System.Windows.Forms.Button insertSetOfState;
        private System.Windows.Forms.TextBox txt_stringInput;
        private System.Windows.Forms.Button btn_checkInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_reSet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
    }
}

