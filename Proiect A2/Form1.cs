using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Simulator
{
    public partial class Form1 : Form
    {
        String fisier,xreads;
        string[] words;
        string[] words1;
        int j = 0;
        int ticks = 0,index,PC=0,hit=0,miss=0;

       public struct TipInstr //structura pentru fiecare instructiune
        {
           public char tipInstructiune ;
           public int pc_Curent ;
           public int target ;
        };
        TipInstr[] l = new TipInstr[900000];

        public struct instrCache
        {
            public double Size_IC;
            public double Bloc_Size;
            
            public int tip;
        };
        instrCache TipCacheInstruction;

        public struct IC
        {
            public double Tag;
            public double Bloc_Offset;
        };
        IC[] ci;

        public struct DC
        {
            public double Tag;
            public double Bloc_Offset;
        };
        DC[] cd;

        public struct dataCache
        {
            public double Size_DC;
            public double Bloc_Size;
           
        };
        dataCache TipCacheData;

        public struct TipSim
        {
            public double FR;//rata fetch
            public double IRmax;//rata maxima
            public int IBS;//dimensiune buffer
            public double latenta;
            public double nrRegistri;
            public double Mem;
        };
        TipSim TipSimulare;

        public struct Ibs
        {
            public char tipInstr;
            public int PC_Crt;
            public int Target;
        };
        
    

        public Form1()
        {
            InitializeComponent();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TipCacheU_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NumeFisier_TextChanged(object sender, EventArgs e)
        {

        }

        private void NrLoad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void NrRegistri_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Ciclu_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SizeDC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0, k = 0;
            words1 = new string[20];
            string nmfis;
            string[] nm = new string[8];
            
           
            
            OpenFileDialog ofn = new OpenFileDialog();
            ofn.Filter = "TrC Files (*.trc)|*.trc|Text Files (*.txt)|*.txt";
                if (ofn.ShowDialog() == DialogResult.Cancel)
                    return;
                try
                {
                   fisier = ofn.FileName;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error opening file", "File Error",
                                     MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                nmfis = fisier;
                nm = nmfis.Split('\\');
                NumeFisier.Text = nm[nm.Length-1];
                StreamReader file = new StreamReader(fisier);
               // StreamWriter write = new StreamWriter("ceva.txt");
                while (!file.EndOfStream)
                {
                    i = 0;
                    k = 0;
                    xreads = file.ReadLine();
                    words = xreads.Split(' ');
                    
                    while (i < words.Length)
                    {
                        if (words[i] != "") { words1[k] = words[i]; k++; }
                        i++;

                    }
                    k = 1;
                    i = 0;
                    //for (i = 0; i < 15; i++)
                    while(words1[i]!=null)
                    {                       
                        if (k == 1) { l[j].tipInstructiune = Convert.ToChar(words1[i]); k++; }
                        else
                        if (k == 2) {l[j].pc_Curent = Convert.ToInt32(words1[i]); k++;}
                        else
                        if (k == 3) { l[j].target = Convert.ToInt32(words1[i]); k = 1; j++; }
                i++;
                    }
                }
                file.Close();
               // write.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {   //atribuirea parametrilor cache instruction


            //atribuirea parametrilor cache data

            TipCacheData.Bloc_Size = Convert.ToDouble(this.comboBox2.Text);
            TipCacheData.Size_DC = Convert.ToDouble(this.SizeDC.Text);

            //atribuire parametri
            TipSimulare.FR = Convert.ToInt32(this.FR.Text);
            TipSimulare.IBS = Convert.ToInt32(this.IBS.Text);
            TipSimulare.IRmax = Convert.ToInt32(this.IRmaxim.Text);
            TipSimulare.latenta = Convert.ToInt32(this.Latenta.Text);
            TipSimulare.Mem = Convert.ToInt32(this.Memoria.Text);
            TipSimulare.nrRegistri = Convert.ToInt32(this.NrRegistri.Text);
           
            //atribuirea nr. de intructiuni

            int nrinstructiuni=0; 
            int nrLoad = 0;//nr de load
            int nrStore = 0;//nr de store
            int nrBranch = 0;//nr de branch
            int nrartimetic = 0;//nr de A
            int nrtotalinstr = 0; // nr total de instr per ciclu
            int nrintrebranch = 0;
          
            // nr total de instr dintre branch-uri

            //contorizare nr de instructiuni de load,store si nr total de instructiuni
            while (nrinstructiuni < j)
            {
                
                if (l[nrinstructiuni].tipInstructiune.Equals('L'))
                {
                    nrLoad++;
                    nrtotalinstr++;
                    if ((l[nrinstructiuni + 1].tipInstructiune.Equals('L')) || (l[nrinstructiuni + 1].tipInstructiune.Equals('S'))) 
                    { nrtotalinstr += l[nrinstructiuni + 1].pc_Curent - l[nrinstructiuni].pc_Curent-1;
                        nrartimetic+= l[nrinstructiuni + 1].pc_Curent - l[nrinstructiuni].pc_Curent - 1;
                    }
                    else if (l[nrinstructiuni + 1].tipInstructiune.Equals('B'))
                    { nrtotalinstr += l[nrinstructiuni + 1].pc_Curent - l[nrinstructiuni].pc_Curent - 1; 
                        nrartimetic+= l[nrinstructiuni + 1].pc_Curent - l[nrinstructiuni].pc_Curent - 1;}
                }
                if (l[nrinstructiuni].tipInstructiune.Equals('S'))
               {
                   nrStore++;
                   nrtotalinstr++;
                   if ((l[nrinstructiuni + 1].tipInstructiune.Equals('L')) || (l[nrinstructiuni + 1].tipInstructiune.Equals('S'))) 
                   {nrtotalinstr += l[nrinstructiuni + 1].pc_Curent - l[nrinstructiuni].pc_Curent-1;
                   nrartimetic+= l[nrinstructiuni + 1].pc_Curent - l[nrinstructiuni].pc_Curent - 1;
                   }
                   else if (l[nrinstructiuni + 1].tipInstructiune.Equals('B')) 
                   {   nrtotalinstr += l[nrinstructiuni + 1].pc_Curent - l[nrinstructiuni].pc_Curent -1;
                   nrartimetic += l[nrinstructiuni + 1].pc_Curent - l[nrinstructiuni].pc_Curent - 1;
                   }
               }
               if (l[nrinstructiuni].tipInstructiune.Equals('B'))
               {
                   nrBranch++;
                   if (nrinstructiuni == 0) { nrtotalinstr = l[nrinstructiuni].pc_Curent; nrartimetic = 2; }
                   if (l[nrinstructiuni + 1].tipInstructiune.Equals('B')) 
                    {


                        if (l[nrinstructiuni + 1].pc_Curent != l[nrinstructiuni].target)
                        {
                            nrtotalinstr += l[nrinstructiuni + 1].pc_Curent - l[nrinstructiuni].target;
                            nrintrebranch += l[nrinstructiuni + 1].pc_Curent - l[nrinstructiuni].target;
                            nrartimetic += l[nrinstructiuni + 1].pc_Curent - l[nrinstructiuni].target; 
                        }
                    }
                   else if ((l[nrinstructiuni + 1].tipInstructiune.Equals('L')) || (l[nrinstructiuni + 1].tipInstructiune.Equals('S')))
                        if (l[nrinstructiuni + 1].pc_Curent != l[nrinstructiuni].target)
                                    nrtotalinstr += l[nrinstructiuni + 1].pc_Curent - l[nrinstructiuni].target;
               }
             


               nrinstructiuni++;
           }


            nrtotalinstr = nrLoad + nrStore + nrBranch + nrartimetic + nrintrebranch;
          
         
              
         
      //      this.NrInstructiuni.Text=

           
    
           this.Branch.Text = nrBranch.ToString(); 
          
            //afis nr de branch-uri
           this.textBox5.Text = nrStore.ToString();//afis nr de instr de store
           this.NrLoad.Text = nrLoad.ToString();
           nrtotalinstr = nrLoad + nrStore + nrBranch + nrartimetic + nrintrebranch;
           NrInstructiuni.Text = nrtotalinstr.ToString();
           ticks = nrtotalinstr - nrLoad + nrStore + nrBranch;
           textBox1.Text = ticks.ToString();



            //  this.textBox1.Text =ticks.ToString();
            

       //    int x = 0;

           int ciclu = nrtotalinstr - nrLoad - nrStore - nrBranch ;
         
           Ciclu.Text = ciclu.ToString();
           double ir;

           ir = (Convert.ToDouble(nrtotalinstr) / Convert.ToDouble(ticks));
          this.textBox3.Text = ir.ToString();
           
           int i;

           Ibs[] buffer = new Ibs[TipSimulare.IBS];
           
           ci = new IC[Convert.ToInt32(TipCacheInstruction.Size_IC)];
           cd = new DC[Convert.ToInt32(TipCacheData.Size_DC)];

           for ( i = 0; i < TipCacheInstruction.Size_IC; i++)
           {               
               ci[i].Tag = i / TipCacheInstruction.Size_IC;
               ci[i].Bloc_Offset = (((i) % (TipCacheInstruction.Size_IC)) / (TipCacheInstruction.Bloc_Size));
           }

           for ( i = 0; i < TipCacheData.Size_DC; i++)
           {               
               cd[i].Tag = i / TipCacheData.Size_DC;
               cd[i].Bloc_Offset = (((i) % (TipCacheData.Size_DC)) / (TipCacheData.Bloc_Size));
           }
           int index1=0;
           i=0;

        /*   for (int f = 0; f < j; i++)
           {
               while ( i < TipSimulare.IBS)
               {
                   for (int ct = 0; ct < TipSimulare.FR; ct++)
                   {
                       if (ct == l[f].pc_Curent)
                       {
                           buffer[ct].tipInstr = l[f].tipInstructiune;
                           buffer[ct].PC_Crt = l[f].pc_Curent;
                           buffer[ct].Target = l[f].target;
                           index = l[f].target;
                           index1 = l[f].pc_Curent;
                       }
                       else
                       {
                           buffer[ct].tipInstr = 'A';
                           buffer[ct].PC_Crt = i;
                           buffer[ct].Target = 0;
                       }
                       PC++;
                   }
                   ticks++;
                   i += index1;
                   f++;
                   PC=index-3;
                   for (int ct = 0; ct < index1; ct++)
                       buffer[ct] = buffer[index1 + ct];
                   for (int ct = index1; ct < TipSimulare.FR + index1; ct++)
                   {                      
                           if (PC == l[f].pc_Curent)
                       {
                           buffer[ct].tipInstr = l[f].tipInstructiune;
                           buffer[ct].PC_Crt = l[f].pc_Curent;
                           buffer[ct].Target = l[f].target;
                           index = l[f].target;
                           index1 = l[f].pc_Curent;
                       }
                       else
                       {
                           buffer[ct].tipInstr = 'A';
                           buffer[ct].PC_Crt = i;
                           buffer[ct].Target = 0;
                       }
                       PC++;
                   }


                   ticks++;
               }
           }*/
           

        }

        private void FR_SelectedIndexChanged(object sender, EventArgs e)
        {
            SizeBloc.Text = FR.Text;
            if (Convert.ToInt32(FR.Text) > Convert.ToInt32(IBS.Text)) IBS.Text = FR.Text;
        }

        private void SizeBloc_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           IRmaxim.Text = FR.Text;
           if (Convert.ToInt32(FR.Text) > Convert.ToInt32(IRmaxim.Text)) IRmaxim.Text = FR.Text;
           IRmaxim.Enabled = false;

        }
       
        
       


    }

    
            }
        


  
