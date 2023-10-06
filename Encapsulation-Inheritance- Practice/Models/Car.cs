using System;


public class Car
{
	public string color;
	public int speed;
	private string vin;

	public string Vin
	{

		get
        {
			if(speed > 450)
			{
				return vin;

			}

			return null;
		}



		set
		{
			vin = value;
		}



	}
}


