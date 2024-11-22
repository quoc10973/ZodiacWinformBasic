using Services;

namespace Zodiac
{
    //class Form1 chính là class kế thừa cái class gốc mà window cung cấp để render ra cửa sổ
    public partial class IdolZodiacManager : Form
    {
        public IdolZodiacManager()
        {
            InitializeComponent();
        }

        private void btnShowImage_Click(object sender, EventArgs e)
        {
            //đưa ảnh vào ram
            Image img = Image.FromFile("signs\\Aries.jpg");

            //show ảnh
            picImage.Image = img;
        }

        private void ZodiacManager_Load(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                //gọi thư viện trả về cung hoàng đạo
                int day = int.Parse(txtDay.Text);
                int month = int.Parse(txtMonth.Text);
                if (0 < day && day < 32 && month < 13)
                {
                    string getZodiac = IdolZodiacCalculator.GetIdolZodiac(day, month);

                    string idolZodiacImage = "signs\\" + getZodiac + ".jpg";

                    string idolName = IdolZodiacCalculator.GetIdolName(getZodiac);

                    Image img = Image.FromFile(idolZodiacImage);
                    picImage.Image = img;

                    lblResult.Text = $"You are: {getZodiac}/{idolName}";
                }
                else
                {
                    Image img = Image.FromFile("signs\\cat.jpg");
                    picImage.Image = img;
                    lblResult.Text = $"Invalid day/month, try again!";
                }
            }
            catch (Exception ex)
            {
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            //Hỏi xác nhận có thật sự muốn thoát hay không?
            //string text, string tilte, msgboxbutton, msgboxicon

            DialogResult answer = MessageBox.Show("Do you want to exit?","Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // hàm này trả về giá trị lựa chọn của user đã click Yes/No -> giá trị này thuộc data type DialogResult(hộp hội thoại) 
            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
