using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SnakeGameWinforms
{
    class Snake
    {
        public int Step { get; } = 20;
        public int HorVelocity { get; set; } = 0;
        public int VerVelocity { get; set; } = 0;

        public List<PictureBox> body = new List<PictureBox>();
        public Snake()
        {
            InitializeSnake();
        }

        private void InitializeSnake()
        {
            PictureBox pixel = new PictureBox();
            pixel.BackColor = Color.Red;
            pixel.Width = 20;
            pixel.Height = 20;
            pixel.Left = 200;
            pixel.Top = 200;

            body.Add(pixel);
        }

        /// <summary>
        /// Turn snake
        /// </summary>
        /// <param name="direction">3 - right, 9 - left, 6 - down, 12 - up</param>

        public void Turn(int direction)
        {
            switch (direction)
            {
                case 3: //turn right
                    this.HorVelocity = 1;
                    this.VerVelocity = 0;
                    break;
                case 9: //turn left
                    this.HorVelocity = -1;
                    this.VerVelocity = 0;
                    break;
                case 6: //turn down
                    this.HorVelocity = 0;
                    this.VerVelocity = 1;
                    break;
                case 12: //turn up
                    this.HorVelocity = 0;
                    this.VerVelocity = -1;
                    break;
            }
        }

        /// <summary>
        /// stop the snake
        /// </summary>

        public void Stop()
        {
            this.HorVelocity = 0;
            this.VerVelocity = 0;
        }


    }
}
