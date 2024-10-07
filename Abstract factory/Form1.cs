namespace Abstract_factory
{
    public partial class Form1 : Form
    {
        private ComboBox shapeComboBox;
        private ComboBox comboBox1;
        private Button drawButton;
        

        private InterfaceFactory currentFactory;
        private Interface Interface;
        public Form1()
        {
            InitializeComponent();
            comboBox1 = new ComboBox();
            drawButton = new Button();

            comboBox1.Items.AddRange(new string[] { "�������", "�����", "�������", "������"});

            drawButton.Text = "����������";
            drawButton.Click += DrawButton_Click;

            Controls.Add(comboBox1);
            Controls.Add(drawButton);

            comboBox1.Location = new System.Drawing.Point(10, 40);
            drawButton.Location = new System.Drawing.Point(10, 70);
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
           
            switch (comboBox1.SelectedItem.ToString())
            {
                case "�������":
                    currentFactory = new RedFactory();
                    Interface = currentFactory.CreateFigures();
                    break;
                case "�����":
                    currentFactory = new BlueFactory();
                    Interface = currentFactory.CreateFigures();
                    break;
                case "�������":
                    currentFactory = new GreenFactory();
                    Interface = currentFactory.CreateFigures();
                    break;
                case "������":
                    currentFactory = new YellowFactory();
                    Interface = currentFactory.CreateFigures();
                    break;
            }
            panel1.Invalidate();
        }

        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Interface?.Draw(e.Graphics);
        }
    }
}
