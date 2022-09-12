namespace Aula_12_09
{
    public partial class Form1 : Form
    {
        public int[] velha;
        public int jogador;

        public Form1()
        {
            InitializeComponent();
        }

        public void testeGanhou()
        {
            if (velha[0] == velha[1] && velha[1] == velha[2] && velha[0] != -1 && velha[1] != -1 && velha[2] != -1)
            {
                traco.Image = global::Aula_12_09.Properties.Resources.traco4;
                traco.Visible = true;

                if (velha[0] == 0)
                {
                    MessageBox.Show("Jogador BOLA ganhou!", "Jogo da Velha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (velha[0] == 1)
                {
                    MessageBox.Show("Jogador X ganhou!", "Jogo da Velha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (velha[3] == velha[4] && velha[4] == velha[5] && velha[3] != -1 && velha[4] != -1 && velha[5] != -1)
            {
                traco.Image = global::Aula_12_09.Properties.Resources.traco5;
                traco.Visible = true;

                if (velha[3] == 0)
                {
                    MessageBox.Show("Jogador BOLA ganhou!", "Jogo da Velha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (velha[3] == 1)
                {
                    MessageBox.Show("Jogador X ganhou!", "Jogo da Velha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (velha[6] == velha[7] && velha[7] == velha[8] && velha[6] != -1 && velha[7] != -1 && velha[8] != -1 )
            {
                traco.Image = global::Aula_12_09.Properties.Resources.traco6;
                traco.Visible = true;

                if (velha[6] == 0)
                {
                    MessageBox.Show("Jogador BOLA ganhou!", "Jogo da Velha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (velha[6] == 1)
                {
                    MessageBox.Show("Jogador X ganhou!", "Jogo da Velha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (velha[0] == velha[3] && velha[3] == velha[6] && velha[0] != -1 && velha[3] != -1 && velha[6] != -1 )
            {
                traco.Image = global::Aula_12_09.Properties.Resources.traco7;
                traco.Visible = true;

                if (velha[0] == 0)
                {
                    MessageBox.Show("Jogador BOLA ganhou!", "Jogo da Velha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (velha[0] == 1)
                {
                    MessageBox.Show("Jogador X ganhou!", "Jogo da Velha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (velha[1] == velha[4] && velha[4] == velha[7] && velha[1] != -1 && velha[4] != -1 && velha[7] != -1)
            {
                traco.Image = global::Aula_12_09.Properties.Resources.traco3;
                traco.Visible = true;

                if (velha[1] == 0)
                {
                    MessageBox.Show("Jogador BOLA ganhou!", "Jogo da Velha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (velha[1] == 1)
                {
                    MessageBox.Show("Jogador X ganhou!", "Jogo da Velha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (velha[2] == velha[5] && velha[5] == velha[8] && velha[2] != -1 && velha[5] != -1 && velha[8] != -1)
            {
                traco.Image = global::Aula_12_09.Properties.Resources.traco3;
                traco.Visible = true;

                if (velha[2] == 0)
                {
                    MessageBox.Show("Jogador BOLA ganhou!", "Jogo da Velha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (velha[2] == 1)
                {
                    MessageBox.Show("Jogador X ganhou!", "Jogo da Velha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (velha[0] == velha[4] && velha[4] == velha[8] && velha[0] != -1 && velha[4] != -1 && velha[8] != -1)
            {
                traco.Image = global::Aula_12_09.Properties.Resources.traco1;
                traco.Visible = true;

                if (velha[0] == 0)
                {
                    MessageBox.Show("Jogador BOLA ganhou!", "Jogo da Velha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (velha[0] == 1)
                {
                    MessageBox.Show("Jogador X ganhou!", "Jogo da Velha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (velha[2] == velha[4] && velha[4] == velha[6] && velha[2] != -1 && velha[4] != -1 && velha[6] != -1)
            {
                traco.Image = global::Aula_12_09.Properties.Resources.traco2;
                traco.Visible = true;

                if (velha[2] == 0)
                {
                    MessageBox.Show("Jogador BOLA ganhou!", "Jogo da Velha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (velha[2] == 1)
                {
                    MessageBox.Show("Jogador X ganhou!", "Jogo da Velha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();

            label0.Image = null;
            label1.Image = null;
            label2.Image = null;
            label3.Image = null;
            label4.Image = null;
            label5.Image = null;
            label6.Image = null;
            label7.Image = null;
            label8.Image = null;

            this.velha = new int[9];
            this.jogador = rnd.Next(2);

            for (int i = 0; i < 9; i++)
            {
                this.velha[i] = -1;
            }
        }

        private void label0_Click(object sender, EventArgs e)
        {
            if (this.velha[0] == -1)
            {
                this.velha[0] = this.jogador;

                if (this.jogador == 0)
                {
                    label0.Image = global::Aula_12_09.Properties.Resources.bola;
                    this.jogador = 1;
                }
                else if (this.jogador == 1)
                {
                    label0.Image = global::Aula_12_09.Properties.Resources.x;
                    this.jogador = 0;
                }
                testeGanhou();

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

            if (this.velha[1] == -1)
            {
                this.velha[1] = this.jogador;

                if (this.jogador == 0)
                {
                    label1.Image = global::Aula_12_09.Properties.Resources.bola;
                    this.jogador = 1;
                }
                else if (this.jogador == 1)
                {
                    label1.Image = global::Aula_12_09.Properties.Resources.x;
                    this.jogador = 0;
                }
                testeGanhou();

            }
        }
       

        private void label2_Click_1(object sender, EventArgs e)
        {
            if (this.velha[2] == -1)
            {
                this.velha[2] = this.jogador;

                if (this.jogador == 0)
                {
                    label2.Image = global::Aula_12_09.Properties.Resources.bola;
                    this.jogador = 1;
                }
                else if (this.jogador == 1)
                {
                    label2.Image = global::Aula_12_09.Properties.Resources.x;
                    this.jogador = 0;
                }
                testeGanhou();

            }

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            if (this.velha[3] == -1)
            {
                this.velha[3] = this.jogador;

                if (this.jogador == 0)
                {
                    label3.Image = global::Aula_12_09.Properties.Resources.bola;
                    this.jogador = 1;
                }
                else if (this.jogador == 1)
                {
                    label3.Image = global::Aula_12_09.Properties.Resources.x;
                    this.jogador = 0;
                }
                testeGanhou();

            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (this.velha[4] == -1)
            {
                this.velha[4] = this.jogador;

                if (this.jogador == 0)
                {
                    label4.Image = global::Aula_12_09.Properties.Resources.bola;
                    this.jogador = 1;
                }
                else if (this.jogador == 1)
                {
                    label4.Image = global::Aula_12_09.Properties.Resources.x;
                    this.jogador = 0;
                }
                testeGanhou();

            }

        }

        private void traco_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            if (this.velha[5] == -1)
            {
                this.velha[5] = this.jogador;

                if (this.jogador == 0)
                {
                    label5.Image = global::Aula_12_09.Properties.Resources.bola;
                    this.jogador = 1;
                }
                else if (this.jogador == 1)
                {
                    label5.Image = global::Aula_12_09.Properties.Resources.x;
                    this.jogador = 0;
                }
                testeGanhou();

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (this.velha[6] == -1)
            {
                this.velha[6] = this.jogador;

                if (this.jogador == 0)
                {
                    label6.Image = global::Aula_12_09.Properties.Resources.bola;
                    this.jogador = 1;
                }
                else if (this.jogador == 1)
                {
                    label6.Image = global::Aula_12_09.Properties.Resources.x;
                    this.jogador = 0;
                }
                testeGanhou();

            }

        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            if (this.velha[7] == -1)
            {
                this.velha[7] = this.jogador;

                if (this.jogador == 0)
                {
                    label7.Image = global::Aula_12_09.Properties.Resources.bola;
                    this.jogador = 1;
                }
                else if (this.jogador == 1)
                {
                    label7.Image = global::Aula_12_09.Properties.Resources.x;
                    this.jogador = 0;
                }
                testeGanhou();

            }

        }

        private void label8_Click_1(object sender, EventArgs e)
        {
            if (this.velha[8] == -1)
            {
                this.velha[8] = this.jogador;

                if (this.jogador == 0)
                {
                    label8.Image = global::Aula_12_09.Properties.Resources.bola;
                    this.jogador = 1;
                }
                else if (this.jogador == 1)
                {
                    label8.Image = global::Aula_12_09.Properties.Resources.x;
                    this.jogador = 0;
                }
                testeGanhou();

            }

        }
    }
}