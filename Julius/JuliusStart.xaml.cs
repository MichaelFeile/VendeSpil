namespace VendeSpil.Julius;

public partial class JuliusStart : ContentPage
{
	public JuliusStart()
	{
		InitializeComponent();
	}

	int testok = 0;
	decimal total = 0;


    private void Button_Clicked(object sender, EventArgs e)
    {
		Random r = new Random();

		for (int i = 0; i < 100000; i++) 
		{
			total = total + 1;
			List<int> list = new List<int>();
            list.Add(r.Next(1, 7));
            list.Add(r.Next(1, 7));
            list.Add(r.Next(1, 7));
			if(Test(list))
			{
				testok = testok + 1;
			}
        }
		decimal res = total / testok;
		tekstfelt.Text = res.ToString("F4");
	}

	bool Test(List<int> list)
	{
		if (list[0] == 6 && list[1] == 6 && list[2] == 6)
		{
			return true;
		}
		else
		{
			return false;
		}
	}

    bool Test(int t)
    {
        if (t == 6)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}