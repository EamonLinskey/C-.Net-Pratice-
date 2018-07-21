using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Console;


namespace SnakeGame
{
    public partial class snakeForm : Form
    {
        // Declarations of all of my Global Variables. I think some of them may 
        // be redundant and could be reduced on another go through. In some cases
        // the redundency is needed to make sure that they are correctly set each
        // time a new game is started, including the first instance;
        private string intention, prevIntention, prevMove = "up";
        private snakeBody prevTail;
        private Point prevTailPrevLocation;
        private powerupBody prevPowerup;
        private Point powerupLocation = new Point();
        public List<snakeBody> snakeWholeBody = new List<snakeBody> { };
        private string[] intentionArray = { };
        public List<string> intentionsList = new List<string> { "empty" };
        private List<Point> forbiddenLocations = new List<Point>();
        private Timer timer = new System.Windows.Forms.Timer();
        private bool dead = false;
        private string playerName = "Player 1";
        private int score = 0;
        private List<int> highScores = new List<int> { 0, 0, 0, 0, 0 };
        private List<string> highScoreHolders = new List<string> { "Player1", "Player2", "Player3", "Player4", "Player5"};
        
        // Initializing all of the Designs fomr the Designer Form
        public snakeForm()
        {
            InitializeComponent();
        }

        // Button on click form navigations
        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quitButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void homeButtonFromHS_Click(object sender, EventArgs e)
        {
            highScoresPanel.Visible = false;
            mainPanel.Visible = true;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            playerName = nameTextBox.Text;
            updateHighScores();
            highScoresButton_Click(sender, e);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            highScoresPanel.Visible = true;
            gamePanel.Visible = true;
            startGameButton.Visible = true;
            gameOverPanel.Visible = false;
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            gameOverPanel.Visible = false;
            startGameButton_Click(sender, e);
        }

        private void nameTextBox_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
        }

        private void highScoresButton_Click(object sender, EventArgs e)
        {
            // Updates text to show relevant scores. Could be seperated into for loop in the next round of edits
            score1Label.Text = "1. " + highScoreHolders[0] + " " + Convert.ToString(highScores[0]);
            score2Label.Text = "2. " + highScoreHolders[1] + " " + Convert.ToString(highScores[1]);
            score3Label.Text = "3. " + highScoreHolders[2] + " " + Convert.ToString(highScores[2]);
            score4Label.Text = "4. " + highScoreHolders[3] + " " + Convert.ToString(highScores[3]);
            score5Label.Text = "5. " + highScoreHolders[4] + " " + Convert.ToString(highScores[4]);

            highScoresPanel.Visible = true;
            gamePanel.Visible = false;
        }

        private void highScoresbutton2_Click(object sender, EventArgs e)
        {
            highScoresButton_Click(sender, e);
        }

        // Function for managing the High Scores Record
        private void updateHighScores()
        {
            // Remove the lowest Score. It will always be the last entry in the list
            highScores.RemoveAt(4);
            highScoreHolders.RemoveAt(4);

            // I use an index here to make sure my players list and high score list remain parallel
            int index = 0;
            for(int i =0; i < highScores.Count(); i++)
            {
                if(score > highScores[i])
                {
                    index = i;
                    break;
                }
            }

            // Add new high scores and player names to their lists at index
            highScores.Insert(index, score);
            highScoreHolders.Insert(index, playerName);
        }

        // New class declarations declared
        public class snakeBody : System.Windows.Forms.PictureBox
        {
            public PictureBox prev { get; set; }
        }

        public class powerupBody : System.Windows.Forms.PictureBox
        {
        }

        // This functions allows us to take  input whenever the user hits a key
        private void snakeForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (gamePanel.Visible)
            {
                updateIntention(e);
            }
        }

        // This function uses the most recent intention from the user to move the sanke
        private void move()
        {
            // temporary variable to mark the snakes next location as "forbidden" on the
            // next loop. This is to cuase a game over whe the head touches the tail
            List<Point> tempLocations = new List<Point>();

            // Iterate though each part of the snake and move it based on the appropriate
            // intention ftom the Intention List
            for (int i=0; i < snakeWholeBody.Count(); i++)
            {
                snakeBody piece = snakeWholeBody[i];
                string direction = intentionsList[i];

                // Switch case used to increment direction. 20 is used to make 
                // sure the snake stay on the grid
                switch (direction)
                {
                    case "left":
                        piece.Left -= 20;
                        break;
                    case "right":
                        piece.Left += 20;
                        break;
                    case "up":
                        piece.Top -= 20;
                        break;
                    case "down":
                        piece.Top += 20;
                        break;
                    default:
                        piece.Top -= 20;
                        break;
                }

                // Update temporary Locations
                tempLocations.Add(piece.Location);
            }

            // Checks to see if the snake is out of bounds or if the head has 
            // touched its body (i.e. forbidden locations)
            if ((snakeWholeBody[0].Location.Y <= 0) ||
                (snakeWholeBody[0].Location.Y >= 460) ||
                (snakeWholeBody[0].Location.X <= 0) ||
                (snakeWholeBody[0].Location.X >= 780) ||
                forbiddenLocations.Contains(snakeWholeBody[0].Location))
            {
                // Remove the head from teh screen for future rounds
                snakeWholeBody[0].Visible = false;

                // Reset forbidden locations and intentions to the defaults
                forbiddenLocations = new List<Point>();
                intentionsList = new List<string> { "up", "up", "up", "up", "up", "up", "up" };

                // Update to allow Game Over to trigger
                dead = true;
            }

            // Checks for Powerups
            if (snakeWholeBody[0].Location == powerupLocation)
            {
                // updates forbidden locations for next move
                forbiddenLocations = tempLocations;

                // Generates new Powerup
                prevPowerup = generatePowerup();

                //Iterates score
                score += 10;
                scoreLabel.Text = "Score: " + score.ToString();

                // Creates new tail piece, adds it to the snake and extends the intentions list
                prevTail = createBodyPart(prevTailPrevLocation, prevTail);
                snakeWholeBody.Add(prevTail);
                intentionsList.Add(intentionsList[intentionsList.Count()-1]);
            }
            else
            {
                // updates forbidden locations for next move
                forbiddenLocations = tempLocations;
            }
            
            // Saves the current move and Tal location for next move
            prevMove = intentionsList[0];
            prevTailPrevLocation = prevTail.Location;

            // Updates intention List
            intentionsList.RemoveAt(intentionsList.Count()-1);
            intentionsList.Insert(0, intention);
        }

        // Generates new powerup for snake to chase
        public powerupBody generatePowerup()
        {
            // make sure the previous powerup has been removed
            if (prevPowerup != null)
            {
                prevPowerup.Visible = false;
            }

            // select random spot on grid for powerup
            Random rand = new Random();
            Point point = new Point(rand.Next(1, 39) * 20, rand.Next(1, 22) * 20);

            // Makes sure the Powerup is not placed in an illegal location
            while (forbiddenLocations.Contains(point))
            {
                // Might not be needed to update rand. But I think it allows me 
                // to get a new random seed
                rand = new Random();
                point.X = rand.Next(1, 39)*20;
                point.Y = rand.Next(1, 22)*20;
            }

            // Creates powerup and saves the location of the previous powerup
            powerupBody powerup = createPowerup(point);
            powerupLocation = powerup.Location;

            return powerup;
        }

        // This is the method to run when the timer is raised. This design It allows the user to
        // update their intentions multiple times in between running this function. Allowing the
        // the snake to move using only the most recent intention
        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {   
            // Completion Condition if the snake dies, Activates Game over screen
            if (dead)
            {
                timer.Stop();
                gameOverPanel.Visible = true;

                // High score updates screen created if user has new high score
                scoreInfoLabel.Text = "You scored " + score + " points!";;
                if (score > highScores.Min())
                {
                    highScoreInfoLabel.Text = "    You got a High Score!";
                    highScoreInfo2.Visible = true;
                    nameTextBox.Visible = true;
                    submitButton.Visible = true;
                }
                else
                {
                    highScoreInfoLabel.Text = "You did not get a high score.Try Again!";
                    highScoreInfo2.Visible = false;
                    nameTextBox.Visible = false;
                    submitButton.Visible = false;
                }
            }
            // If snake is not dead the snake should move every time the ffunction is called
            else
            {
                move();
            }
        }
        
        // Creates the head of the snake
        public snakeBody createHead(Point point)
        {
            snakeBody body = new snakeBody();
            body.Image = Image.FromFile(Application.StartupPath + @"\Images\body.jpg");
            body.Location = point;
            body.Name = "Head";
            body.Size = new Size(20, 20);
            body.SizeMode = PictureBoxSizeMode.AutoSize;
            gamePanel.Controls.Add(body);
            return body;
        }

        // Creates one new body segment of the snake
        private snakeBody createBodyPart(Point point, snakeBody prevBody)
        {
            snakeBody body = new snakeBody();
            body.Image = Image.FromFile(Application.StartupPath + @"\Images\body.jpg");
            body.Location = point;
            body.Name = "Body";
            body.Size = new Size(20, 20);
            body.SizeMode = PictureBoxSizeMode.AutoSize;
            body.prev = prevBody;
            gamePanel.Controls.Add(body);
            return body;
        }

        // Creates new powerup
        public powerupBody createPowerup(Point point)
        {
            powerupBody body = new powerupBody();
            body.Image = Image.FromFile(Application.StartupPath + @"\Images\powerup.jpg");
            body.Location = point;
            body.Name = "Powerup";
            body.Size = new Size(20, 20);
            body.SizeMode = PictureBoxSizeMode.AutoSize;
            gamePanel.Controls.Add(body);
            return body;
        }

        // this function make sure the snake cannot turn directly around and immediately 
        // collide with its closest body segment
        public bool isLegalTurn(KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.A && prevMove == "right") ||
                (e.KeyCode == Keys.D && prevMove == "left")  ||
                (e.KeyCode == Keys.W && prevMove == "down") ||
                (e.KeyCode == Keys.S && prevMove == "up"))
            {
                return false;
            }
            return true;
        }


        private void updateIntention(KeyEventArgs e)
        {
            // Checks if turn is legal
            if (isLegalTurn(e))
            {
                // Turns Key code into direction
                if (e.KeyCode == Keys.A)
                {
                    intention = "left";
                }
                else if (e.KeyCode == Keys.D)
                {
                    intention = "right";
                }
                else if (e.KeyCode == Keys.S)
                {
                    intention = "down";
                }
                else if (e.KeyCode == Keys.W)
                {
                    intention = "up";
                }
                // if the user does not input anything the snake should keep moving the same direction
                else
                {
                    intention = prevIntention;
                }

                // save previous intention
                prevIntention = intention;
            }
            
            // Update intention list for move function
            intentionsList[0] = intention;
        }
   
        // The actual start playing function
        private void startGameButton_Click(object sender, EventArgs e)
        {
            // Cleanup from any previous rounds by making everything invisible
            for (int i = 1; i < snakeWholeBody.Count(); i++)
            {
                snakeWholeBody[i].Visible = false;
            }

            // make sure snake is alive
            dead = false;
            
            // Clear previous forbidden locations
            forbiddenLocations.Clear();

            // reset intentions to defaults
            intentionsList = new List<string> { "up", "up", "up", "up", "up", "up", "up" };

            startGameButton.Visible = false;

            // reset snake body and previous inputs to default
            snakeWholeBody = new List<snakeBody> { };
            prevIntention = "up";
            prevMove = "up";
            intention = "up";

            // Clean up the tick event handelers from previous rounds
            // if the first time nothing happens. On subsequent loops
            // this prevents the speed from doubleing each time
            timer.Tick -= new EventHandler(TimerEventProcessor);

            // reset score
            score = 0;
            scoreLabel.Text = "Score: " + score;
            
            // Create initial Snake 
            Point startPoint = new Point(400, 200);
            snakeBody head = createHead(startPoint);
            snakeWholeBody.Add(head);
            startPoint.Y += 20;
            snakeBody body1 = createBodyPart(startPoint, head);
            snakeWholeBody.Add(body1);
            startPoint.Y += 20;
            snakeBody body2 = createBodyPart(startPoint, body1);
            snakeWholeBody.Add(body2);
            startPoint.Y += 20;
            snakeBody body3 = createBodyPart(startPoint, body2);
            snakeWholeBody.Add(body3);
            startPoint.Y += 20;
            snakeBody body4 = createBodyPart(startPoint, body3);
            snakeWholeBody.Add(body4);
            startPoint.Y += 20;
            snakeBody body5 = createBodyPart(startPoint, body4);
            snakeWholeBody.Add(body5);
            startPoint.Y += 20;
            snakeBody body6 = createBodyPart(startPoint, body5);
            snakeWholeBody.Add(body6);
            prevTail = body6;

            //Initialize first powerup
            prevPowerup = generatePowerup();

            // Sets the timer interval to 0.08 seconds.
            timer.Tick += new EventHandler(TimerEventProcessor);
            timer.Interval = 80;
            timer.Enabled = true;
            timer.Start();
        }
    }
}
