using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace CONTROLADOR
{


    public partial class Form1 : Form
    {
        int anterior = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBoxOSCURO_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOSCURO.Checked)
            {
                this.BackColor = Color.FromArgb(68, 68, 68);
                panel2.BackColor = Color.FromArgb(34, 34, 34);
                panel3.BackColor = Color.FromArgb(34, 34, 34);
                panel4.BackColor = Color.FromArgb(34, 34, 34);
                panel5.BackColor = Color.FromArgb(34, 34, 34);
                panel6.BackColor = Color.FromArgb(34, 34, 34);
                panel7.BackColor = Color.FromArgb(34, 34, 34);
                panel8.BackColor = Color.FromArgb(34, 34, 34);
                comboBoxCOMP.BackColor = Color.FromArgb(68, 68, 68);
                comboBoxCOMP.ForeColor = Color.FloralWhite;
                comboBoxBAUD.BackColor = Color.FromArgb(68, 68, 68);
                comboBoxBAUD.ForeColor = Color.FloralWhite;
                circularProgressBar1.InnerColor = Color.FromArgb(68, 68, 68);
                circularProgressBar1.ForeColor = Color.FloralWhite;
                circularProgressBar1.SuperscriptColor = Color.FromArgb(166, 166, 166);
                comboBoxRPMCUT.BackColor = Color.FromArgb(68, 68, 68);
                comboBoxRELAY.BackColor = Color.FromArgb(68, 68, 68);
                comboBoxINYECTIONTIME.BackColor = Color.FromArgb(68, 68, 68);
                comboBoxRPMCUT.ForeColor = Color.FloralWhite;
                comboBoxRELAY.ForeColor = Color.FloralWhite;
                comboBoxINYECTIONTIME.ForeColor = Color.FloralWhite;
                textBoxREV.ForeColor = Color.FloralWhite;
                textBoxREV.BackColor = Color.FromArgb(68, 68, 68);
                buttonmostrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 34, 34);
                buttonmostrar.BackColor = Color.FromArgb(34,34,34);
                label11.ForeColor = Color.FromArgb(34, 34, 34);
                label12.ForeColor = Color.FromArgb(34, 34, 34);
                label13.ForeColor = Color.FromArgb(34, 34, 34);
                labelon1.ForeColor = Color.FromArgb(34, 34, 34);
                labelon2.ForeColor = Color.FromArgb(34, 34, 34);
                labelon3.ForeColor = Color.FromArgb(34, 34, 34);
                labelon4.ForeColor = Color.FromArgb(34, 34, 34);
            }
            else
            {
                this.BackColor = Color.Gainsboro;
                panel2.BackColor = Color.RoyalBlue;
                panel3.BackColor = Color.RoyalBlue;
                panel4.BackColor = Color.RoyalBlue;
                panel5.BackColor = Color.RoyalBlue;
                panel6.BackColor = Color.RoyalBlue;
                panel7.BackColor = Color.RoyalBlue;
                panel8.BackColor = Color.RoyalBlue;
                comboBoxCOMP.BackColor = Color.Gainsboro;
                comboBoxCOMP.ForeColor = Color.FromArgb(68, 68, 68);
                comboBoxBAUD.BackColor = Color.Gainsboro;
                comboBoxBAUD.ForeColor = Color.FromArgb(68, 68, 68);
                circularProgressBar1.InnerColor = Color.Gainsboro;
                circularProgressBar1.ForeColor = Color.FromArgb(68, 68, 68);
                circularProgressBar1.SuperscriptColor = Color.Gray;
                comboBoxRPMCUT.BackColor = Color.Gainsboro;
                comboBoxRELAY.BackColor = Color.Gainsboro;
                comboBoxINYECTIONTIME.BackColor = Color.Gainsboro;
                comboBoxRPMCUT.ForeColor = Color.FromArgb(68, 68, 68);
                comboBoxRELAY.ForeColor = Color.FromArgb(68, 68, 68);
                comboBoxINYECTIONTIME.ForeColor = Color.FromArgb(68, 68, 68);
                textBoxREV.ForeColor = Color.FromArgb(68, 68, 68);
                textBoxREV.BackColor = Color.Gainsboro;
                buttonmostrar.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
                buttonmostrar.BackColor = Color.RoyalBlue;
                label11.ForeColor = Color.RoyalBlue;
                label12.ForeColor = Color.RoyalBlue;
                label13.ForeColor = Color.RoyalBlue;
                labelon1.ForeColor = Color.RoyalBlue;
                labelon2.ForeColor = Color.RoyalBlue;
                labelon3.ForeColor = Color.RoyalBlue;
                labelon4.ForeColor = Color.RoyalBlue;
            }
        }

        private void DisableComponents()
        {
            //buttonINYECTOR1.Enabled = false;
            //buttonINYECTOR2.Enabled = false;
            //buttonINYECTOR3.Enabled = false;
            //buttonINYECTOR4.Enabled = false;
            buttonRELAY.Enabled = false;
            buttonRPMCUT.Enabled = false;
            buttonINYECTIONTIME.Enabled = false;
            buttonREV.Enabled = false;
            buttonRPMCUT.Enabled=false;
            buttonRELAY.Enabled=false;
            textBoxREV.Enabled = false;
            comboBoxINYECTIONTIME.Enabled = false;
            comboBoxRELAY.Enabled = false;
            comboBoxRPMCUT.Enabled = false;
            if (checkBoxOSCURO.Checked)
            {
                label11.ForeColor = Color.FromArgb(34, 34, 34);
                label12.ForeColor = Color.FromArgb(34, 34, 34);
                label13.ForeColor = Color.FromArgb(34, 34, 34);
                labelon1.ForeColor = Color.FromArgb(34, 34, 34);
                labelon2.ForeColor = Color.FromArgb(34, 34, 34);
                labelon3.ForeColor = Color.FromArgb(34, 34, 34);
                labelon4.ForeColor = Color.FromArgb(34, 34, 34);
            }
            else
            {
                label11.ForeColor = Color.RoyalBlue;
                label12.ForeColor = Color.RoyalBlue;
                label13.ForeColor = Color.RoyalBlue;
                labelon1.ForeColor = Color.RoyalBlue;
                labelon2.ForeColor = Color.RoyalBlue;
                labelon3.ForeColor = Color.RoyalBlue;
                labelon4.ForeColor = Color.RoyalBlue;
            }
            circularProgressBar1.Text = "0";
            circularProgressBar1.Value = 0;
            buttonmostrar.Text = "0";
            progressBar1.Value = 0;
            buttonCONNECT.Text = "CONECTAR";
            buttonREFRESH.Enabled = true;
            comboBoxCOMP.Text = "";
            pictureBoxINYECTOR1.Image = Properties.Resources.inyector_off;
            pictureBoxINYECTOR2.Image = Properties.Resources.inyector_off;
            pictureBoxINYECTOR3.Image = Properties.Resources.inyector_off;
            pictureBoxINYECTOR4.Image = Properties.Resources.inyector_off;
        }

        private void EnableComponents()
        {
            buttonRELAY.Enabled = true;
            buttonRPMCUT.Enabled = true;
            buttonINYECTIONTIME.Enabled = true;
            buttonREV.Enabled = true;
            buttonRPMCUT.Enabled = true;
            buttonRELAY.Enabled = true;
            comboBoxINYECTIONTIME.Enabled = true;
            comboBoxRELAY.Enabled = true;
            comboBoxRPMCUT.Enabled = true;
            textBoxREV.Enabled = true;
            label11.ForeColor = Color.FromArgb(34, 34, 34);
            label12.ForeColor = Color.FromArgb(34, 34, 34);
            label13.ForeColor = Color.FromArgb(34, 34, 34);
            labelon1.ForeColor = Color.FromArgb(34, 34, 34);
            labelon2.ForeColor = Color.FromArgb(34, 34, 34);
            labelon3.ForeColor = Color.FromArgb(34, 34, 34);
            labelon4.ForeColor = Color.FromArgb(34, 34, 34);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                DisableComponents();
                //Getting available comps
                string[] ports = SerialPort.GetPortNames();
                comboBoxCOMP.DataSource = ports;
                //Getting baud rates
                string[] rates = { "9600", "38400", "57600", "115200" };
                comboBoxBAUD.DataSource = rates;
                string[] segundos = { "1", "2", "3", "4", "5", "6", "7", "8", "9"};
                string[] milisegundos = { "1.0", "1.1", "1.2", "1.3", "1.4", "1.5", "1.6", "1.7", "1.8", "1.9",
                 "2.0", "2.1", "2.2", "2.3", "2.4", "2.5", "2.6", "2.7", "2.8", "2.9",
                 "3.0", "3.1", "3.2", "3.3", "3.4", "3.5", "3.6", "3.7", "3.8", "3.9",
                 "4.0", "4.1", "4.2", "4.3", "4.4", "4.5", "4.6", "4.7", "4.8", "4.9",
                 "5.0", "5.1", "5.2", "5.3", "5.4", "5.5", "5.6", "5.7", "5.8", "5.9",
                 "6.0", "6.1", "6.2", "6.3", "6.4", "6.5", "6.6", "6.7", "6.8", "6.9",
                 "7.0", "7.1", "7.2", "7.3", "7.4", "7.5", "7.6", "7.7", "7.8", "7.9",
                 "8.0", "8.1", "8.2", "8.3", "8.4", "8.5", "8.6", "8.7", "8.8", "8.9",
                 "9.0", "9.1", "9.2", "9.3", "9.4", "9.5", "9.6", "9.7", "9.8", "9.9",};
                string[] rates2 = { "500", "1000", "1500", "2000", "2500", "3000", "3500", "4000", "4500", "5000", "5500", "6000" };
                comboBoxRELAY.DataSource = segundos;
                comboBoxINYECTIONTIME.DataSource = milisegundos;
                comboBoxRPMCUT.DataSource = rates2;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if(serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    //MessageBox.Show("Cerrado", "Close");
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Error");
            }
        }

        private void buttonCONNECT_Click(object sender, EventArgs e)
        {
            try
            {
                if(!serialPort1.IsOpen)
                {
                    serialPort1.BaudRate = Convert.ToInt32(comboBoxBAUD.Text);
                    serialPort1.PortName = comboBoxCOMP.Text;
                    serialPort1.Open();

                    progressBar1.Value = 100;
                    buttonCONNECT.Text = "DESCONECTAR";
                    buttonREFRESH.Enabled = false;
                    pictureBoxINYECTOR1.Image = Properties.Resources.inyector_off;
                    pictureBoxINYECTOR2.Image = Properties.Resources.inyector_off;
                    pictureBoxINYECTOR3.Image = Properties.Resources.inyector_off;
                    pictureBoxINYECTOR4.Image = Properties.Resources.inyector_off;
                    EnableComponents();
                }
                else
                {
                    DisableComponents();
                    serialPort1.Close();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("NO SE HA SELECCIONADO EL PUERTO DE COMUNICACIÓN!", "Error");
            }
        }

        private void buttonREFRESH_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBoxCOMP.DataSource = ports;
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            while (serialPort1.IsOpen)
            {
                Console.WriteLine("Puerto abierto");
                try 
                {
                    string serialData = serialPort1.ReadLine();
                    string data = "";
                    Console.WriteLine("Si hay datos");
                    //buttonmostrar.Text = serialData;
                    Console.WriteLine(serialData);
                    int value = 0;
                    if (!String.IsNullOrEmpty(serialData))
                    {
                        if (serialData.IndexOf("$GSO") != -1)
                        {
                            label11.ForeColor = Color.FromArgb(34, 34, 34);
                            label12.ForeColor = Color.GreenYellow;
                            label13.ForeColor = Color.FromArgb(34, 34, 34);
                        }
                        else if (serialData.IndexOf("$GAS") != -1)
                        {
                            label11.ForeColor = Color.FromArgb(34, 34, 34);
                            label13.ForeColor = Color.GreenYellow;
                            label12.ForeColor = Color.FromArgb(34, 34, 34);
                        }
                        else if (serialData.IndexOf("$DIE") != -1)
                        {
                            label12.ForeColor = Color.FromArgb(34, 34, 34);
                            label11.ForeColor = Color.GreenYellow;
                            label13.ForeColor = Color.FromArgb(34, 34, 34);
                        }
                        else if (serialData.IndexOf("$IN1") != -1)
                        {
                            pictureBoxINYECTOR1.Image = Properties.Resources.inyector_on;
                            labelon1.ForeColor = Color.GreenYellow;
                            //labelon1.Visible = true;
                        }
                        else if (serialData.IndexOf("$IN2") != -1)
                        {
                            pictureBoxINYECTOR2.Image = Properties.Resources.inyector_on;
                            labelon2.ForeColor = Color.GreenYellow;
                        }
                        else if (serialData.IndexOf("$IN3") != -1)
                        {
                            pictureBoxINYECTOR3.Image = Properties.Resources.inyector_on;
                            labelon3.ForeColor = Color.GreenYellow;
                        }
                        else if (serialData.IndexOf("$IN4") != -1)
                        {
                            pictureBoxINYECTOR4.Image = Properties.Resources.inyector_on;
                            labelon4.ForeColor = Color.GreenYellow;
                        }
                        else if (serialData.IndexOf("$RPM") != -1)
                        {
                            data = serialData.Remove(0, 4);
                            value = Convert.ToInt32(data);

                            circularProgressBar1.Value = value;
                            circularProgressBar1.Text = data;
                            /*
                            if (value >= circularProgressBar1.Minimum && value <= circularProgressBar1.Maximum)
                            {
                                circularProgressBar1.Value = value;
                                circularProgressBar1.Text = data;
                                //circularProgressBar1.Invoke((MethodInvoker)(() =>
                                //{

                                //}));
                            }
                            else
                            {
                                MessageBox.Show("VALORES FUERA DE RANGO\n\nResetea los valores para continuar", "Error");
                                DisableComponents();
                                serialPort1.Close();
                            }
                            */
                        }
                        else if (serialData.IndexOf("$INT") != -1)
                        {
                            //buttonmostrar.Visible = false;
                            data = serialData.Remove(0, 4);
                            buttonmostrar.Text = data;
                            //buttonmostrar.Visible = true;
                        }
                    }
                }
                catch (Exception)
                {
                    //MessageBox.Show("ERROR DE ENVIO, VERIFIQUE LAS CONEXIONES", "Error");
                    break;
                }
            }
        }

        private void buttonRPMCUT_Click(object sender, EventArgs e)
        {
            string ajuste = comboBoxRPMCUT.Text;
            try
            {
                serialPort1.WriteLine("$CO" + ajuste + "\n");
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR DE ENVIO, VERIFIQUE LAS CONEXIONES", "Error");
            }
        }

        private void buttonINYECTIONTIME_Click(object sender, EventArgs e)
        {
            string ajuste = comboBoxINYECTIONTIME.Text;
            float f1 = float.Parse(ajuste);
            f1 *= 1000;
            int a = (int)f1;
            ajuste = a.ToString();
            try
            {
                serialPort1.WriteLine("$IY" + ajuste + "\n");
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR DE ENVIO, VERIFIQUE LAS CONEXIONES", "Error");
            }
        }

        private void buttonRELAY_Click(object sender, EventArgs e)
        {
            string ajuste = comboBoxRELAY.Text;
            try
            {
                serialPort1.WriteLine("$RE" + comboBoxRELAY.Text + "\n");
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR DE ENVIO, VERIFIQUE LAS CONEXIONES", "Error");
            }
        }

        private void buttonREV_Click(object sender, EventArgs e)
        {
            string ajuste = textBoxREV.Text;
            int numero = int.Parse(ajuste);
            if (anterior == numero && anterior != 0)
            {
                MessageBox.Show("EL VALOR INGRESADO ES EL MISMO QUE SE ENVIÓ ANTERIORMENTE!\n Ingrese un valor diferente para notar algún cambio", "Aviso!");
            }
            else
            {
                anterior = numero;
            }
            string rev = circularProgressBar1.Text;
            int revs = int.Parse(rev);
            try
            {
                //buttonRPMCUT.Text = numero.ToString();
                if (numero + revs > 8000)
                {
                    //buttonREV.Text = (numero + revs).ToString();
                    MessageBox.Show("REVISAR REVOLUCIONES, VALOR INCORRECTO!", "Aviso");
                }
                else if (numero + revs > 0)
                {
                    serialPort1.WriteLine("$AR" + ajuste + "\n");
                    textBoxREV.Text = "0";
                }
                else if(numero + revs < 0)
                {
                    MessageBox.Show("REVISAR REVOLUCIONES, VALOR INCORRECTO!", "Aviso");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ESPACIO SOLO PARA VALORES ENTEROS!", "Error");
            }
        }
    }
}
