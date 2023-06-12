using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PemrogramanPraktikum9
{
	public class PrinterWindows
	{
		public virtual void Show()
		{
			Console.WriteLine("\nPrinterWindows display dimension: 9.5*12");
		}

		public virtual void Print()
		{
			Console.WriteLine("PrinterWindows printing....");
		}
	}

	public class Epson : PrinterWindows
	{
		public override void Show()
		{
			Console.WriteLine("\nEpson display dimension: 10*11");
		}

		public override void Print()
		{
			Console.WriteLine("Epson printer printing....");
		}
	}

	public class Canon : PrinterWindows
	{
		public override void Show()
		{
			Console.WriteLine("\nCanon display dimension: 9.5*12");
		}

		public override void Print()
		{
			Console.WriteLine("Canon printer printing....");
		}
	}

	public class LaserJet : PrinterWindows
	{
		public override void Show()
		{
			Console.WriteLine("\nLaserJet display dimension: 12*12");
		}

		public override void Print()
		{
			Console.WriteLine("LaserJet printer printing....");
		}
	}
}
