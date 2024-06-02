using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TicTacToe
{

    //abstraction of the GUI Form of the Game.
    // ...

    // Inheritance - Form1 class inherits from the Form class

    public partial class Form1 : Form
    {
        bool player = false;
        string userone = "X";
        string usertwo = "O";
        string winner = "";
        int playerone = 0;
        int playertwo = 0;
        public Form1()
        {
            InitializeComponent();
        }

        //Method overriding 
        class derived_class : Form1
        {
            public void newGame()
            {
                this.winner = "Computer";
            }
        }

        public void sort()
        {
            /*int i = 0; string str;
            StreamReader sr = new StreamReader("fs.Text");
            List<string> lst = new List<string>();
            while ((str = sr.ReadLine()) != null)
            {
                lst.Add(str);
            }
            sr.Close();
            string[] lines = lst.ToArray();
            Array.Sort(lines);*/

            var sortedPlayersByScores = File.ReadAllLines("fs.Text")
                                  .Select(line => line.Split(' '))
                                  .Select(elem => new
                                   Tuple<string, int>(elem[0], int.Parse(elem[1])))
                                  .OrderByDescending(x => x.Item2);

            foreach (var item in sortedPlayersByScores)
            {
                label10.Text += item;
                label10.Text += "\n";
            }
        }
        
        // Polymorphism - Method Overloading
        public void newGame(String abc)
        {
            // ...
        }
        public void newGame()
        {
            this.textBox1.Text ="";
            this.textBox2.Text ="";
            this.winner = "";
           this.playerone = 0;
           this.playertwo = 0;
            label1.Text = "Winner :";
            label2.Text = "Player 1 : ";
            label3.Text = "player 2 : ";
            
            this.winner = " ";
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        // Encapsulation - StopButtons method to disable button clicks
        private void tictactoe_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (player)
            {
                btn.Text = usertwo;
            }
            else
            {
                btn.Text = userone;
            }
            player = !player;
            btn.Click -= new EventHandler(tictactoe_Click);
            // Encapsulation - StopButtons method to disable button clicks
            checkforwinner();
        }


        // String Manipulation
        private void button10_Click(object sender, EventArgs e)
        {
            
        }
        //The method to reset all the setting to default.
        public void reset()
        {
            button1.Text = " ";
            button2.Text = " ";
            button3.Text = " ";
            button4.Text = " ";
            button5.Text = " ";
            button6.Text = " ";
            button7.Text = " ";
            button8.Text = " ";
            button9.Text = " ";
            
        }

        //the method to ensure that one button only clicks once 
        public void stop()
        {
            button1.Click -= new EventHandler(tictactoe_Click);
            button2.Click -= new EventHandler(tictactoe_Click);
            button3.Click -= new EventHandler(tictactoe_Click);
            button4.Click -= new EventHandler(tictactoe_Click);
            button5.Click -= new EventHandler(tictactoe_Click);
            button6.Click -= new EventHandler(tictactoe_Click);
            button7.Click -= new EventHandler(tictactoe_Click);
            button8.Click -= new EventHandler(tictactoe_Click);
            button9.Click -= new EventHandler(tictactoe_Click);
        }

        //The method to check for the winner.
        public void checkforwinner()
        {
            if(button1.Text.Equals(button2.Text) && button2.Text.Equals(button3.Text))
            {
                if(button1.Text == "X")
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    
                    DialogResult result = MessageBox.Show("Player one wins", "Winner", buttons);
                    if (result == DialogResult.OK)
                    {
                        //abstraction
                        stop();
                        winner = textBox1.Text;
                        playerone += 10;
                        

                    }
                }
                else if(button1.Text=="O")
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                   
                    DialogResult result = MessageBox.Show("Player Two wins", "Winner", buttons);
                    if (result == DialogResult.OK)
                    {
                        //abstraction
                        stop();
                        winner = textBox2.Text;
                        playertwo += 10;
                    }
                }
            }

            else if (button4.Text.Equals(button5.Text) && button5.Text.Equals(button6.Text))
            {
                if (button4.Text == "X")
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    
                    DialogResult result = MessageBox.Show("Player one wins", "Winner", buttons);
                    if (result == DialogResult.OK)
                    {
                        //this.Close();
                        // reset();
                        stop();
                        winner = textBox1.Text;
                        playerone += 10;

                    }
                }
                else if (button4.Text == "O")
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                   
                    DialogResult result = MessageBox.Show("Player Two wins", "Winner", buttons);
                    if (result == DialogResult.OK)
                    {
                        //abstraction
                        stop();
                        winner = textBox2.Text;
                        playertwo += 10;
                    }
                }
            }



            else if (button7.Text.Equals(button8.Text) && button8.Text.Equals(button9.Text))
            {
                if (button7.Text == "X")
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
              
                    DialogResult result = MessageBox.Show("Player one wins", "Winner", buttons);
                    if (result == DialogResult.OK)
                    {
                        //abstraction
                        stop();
                        winner = textBox1.Text;
                        playerone += 10;

                    }
                }
                else if (button7.Text == "O")
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                   
                    DialogResult result = MessageBox.Show("Player Two wins", "Winner", buttons);
                    if (result == DialogResult.OK)
                    {
                        
                        stop();
                        winner = textBox2.Text;
                        playertwo += 10;
                    }
                }
            }

            else if (button1.Text.Equals(button4.Text) && button4.Text.Equals(button7.Text))
            {
                if (button1.Text == "X")
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                   
                    DialogResult result = MessageBox.Show("Player one wins", "Winner", buttons);
                    if (result == DialogResult.OK)
                    {
                        
                        stop();
                        winner = textBox1.Text;
                        playerone += 10;

                    }
                }
                else if (button1.Text == "O")
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                  
                    DialogResult result = MessageBox.Show("Player Two wins", "Winner", buttons);
                    if (result == DialogResult.OK)
                    {
                        //abstarction
                        stop();
                        winner = textBox2.Text;
                        playertwo += 10;
                    }
                }
            }


            else if (button2.Text.Equals(button5.Text) && button5.Text.Equals(button8.Text))
            {
                if (button2.Text == "X")
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    
                    DialogResult result = MessageBox.Show("Player one wins", "Winner", buttons);
                    if (result == DialogResult.OK)
                    {
                        
                        stop();
                        winner = textBox1.Text;
                        playerone += 10;

                    }
                }
                else if (button2.Text == "O")
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    
                    DialogResult result = MessageBox.Show("Player Two wins", "Winner", buttons);
                    if (result == DialogResult.OK)
                    {
                        
                        stop();
                        winner = textBox2.Text;
                        playertwo += 10;
                    }
                }
            }

            else if (button3.Text.Equals(button6.Text) && button6.Text.Equals(button9.Text))
            {
                if (button3.Text == "X")
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    
                    DialogResult result = MessageBox.Show("Player one wins", "Winner", buttons);
                    if (result == DialogResult.OK)
                    {
                        stop();
                        winner = textBox1.Text;
                        playerone += 10;

                    }
                }
                else if (button3.Text == "O")
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                   
                    DialogResult result = MessageBox.Show("Player Two wins", "Winner", buttons);
                    if (result == DialogResult.OK)
                    {
                        
                        stop();
                        winner = textBox2.Text;
                        playertwo += 10;
                    }
                }
            }


            else if (button1.Text.Equals(button5.Text) && button5.Text.Equals(button9.Text))
            {
                if (button1.Text == "X")
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    
                    DialogResult result = MessageBox.Show("Player one wins", "Winner", buttons);
                    if (result == DialogResult.OK)
                    {
                        
                        stop();
                        winner = textBox1.Text;
                        playerone += 10;

                    }
                }
                else if (button1.Text == "O")
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    
                    DialogResult result = MessageBox.Show("Player Two wins", "Winner", buttons);
                    if (result == DialogResult.OK)
                    {
                        
                        stop();
                        winner = textBox2.Text;
                        playertwo += 10;
                    }
                }
            }

            if (button3.Text.Equals(button5.Text) && button5.Text.Equals(button7.Text))
            {
                if (button3.Text == "X")
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                   
                    DialogResult result = MessageBox.Show("Player one wins", "Winner", buttons);
                    if (result == DialogResult.OK)
                    {
                        
                        stop();
                        winner = textBox1.Text;
                        playerone += 10;

                    }
                }
                else if (button3.Text == "O")
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                
                    DialogResult result = MessageBox.Show("Player Two wins", "Winner", buttons);
                    if (result == DialogResult.OK)
                    {
                        
                        stop();
                        winner = textBox2.Text;
                        playertwo += 10;
                    }
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //abstraction of the implementation of the method newGame();
        private void button11_Click(object sender, EventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text + ":";
            label3.Text = textBox2.Text + ":";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            
            


        }

        private void button13_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
            label10.Text = "";
            label2.Text = textBox1.Text + ":";
            label3.Text = textBox2.Text + ":";
        }

        private void label9_Click(object sender, EventArgs e)
        {
            reset();
            //Abstraction 
            button1.Click += new EventHandler(tictactoe_Click);
            button2.Click += new EventHandler(tictactoe_Click);
            button3.Click += new EventHandler(tictactoe_Click);
            button4.Click += new EventHandler(tictactoe_Click);
            button5.Click += new EventHandler(tictactoe_Click);
            button6.Click += new EventHandler(tictactoe_Click);
            button7.Click += new EventHandler(tictactoe_Click);
            button8.Click += new EventHandler(tictactoe_Click);
            button9.Click += new EventHandler(tictactoe_Click);
            label1.Text = "Winner:" + winner;  // String manipulation - Concatenating the winner name in the label
            label2.Text = textBox1.Text + " " + playerone.ToString() + " "; // String manipulation - Concatenating the winner name in the label
            label3.Text = textBox2.Text + " " + playertwo.ToString()+ " "; // String manipulation - Concatenating the winner name in the label

        }

        public void highscores()
        {
            int counter = 0;
            int rows = 11;
            string line;
            using (StreamReader reader = new StreamReader("fs.Text"))
            {
                while (counter < rows)
                {
                    line = reader.ReadLine();
                    label10.Text += line;
                    label10.Text += "\n";
                    counter++;
                }
            }
        }
        
        private void label8_Click(object sender, EventArgs e)
        {

            

            string path = "fs.Text";



            if (playerone > playertwo)
            {


                // This text is added only once to the file.
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(label2.Text);

                    }
                }

                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(label2.Text);

                }

                MessageBox.Show("Content is written in file successfully");
            }




            else if (playertwo > playerone)
            {

                // This text is added only once to the file.
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(label3.Text);
                        sw.Close();

                    }
                }

                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(label3.Text);
                    sw.Close();

                }

                MessageBox.Show("Content is written in file successfully");
            }



            //highscores();
            sort();
            newGame();
        }


        
    }


}
