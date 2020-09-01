using System;
using System.Text;

namespace Org.RyanLiu.StringDate
{
	/// <summary>
	/// Summary description for StringDateUtil.
	/// </summary>
	public class StringDateUtil
	{
		public const  String LINE_SPLITTER = "\r\n";

		public static String  SortLines(String[] lines)
		{
			Array.Sort(lines);
			
			return AddEndSymbol(lines, "" );
		}	

		
		public static  String AddEndSymbol(String[] lines, String symbol)
		{
			StringBuilder sb = new StringBuilder(300 );
			for(int i=0; i<lines.Length ; i++ ) 
			{
				sb.Append(lines[i]).Append( symbol).Append(StringDateUtil.LINE_SPLITTER )  ;
			}
			
			//remove last split char
			if(sb.Length >= StringDateUtil.LINE_SPLITTER.Length)  sb.Length -= StringDateUtil.LINE_SPLITTER.Length;

			return sb.ToString();

		}

	

		public static  String AddSymbol(String[] lines, String symbol, bool atBegin)
		{
			StringBuilder sb = new StringBuilder(300);
			for(int i=0; i<lines.Length ; i++ ) 
			{
				if(atBegin) sb.Append(symbol).Append(lines[i]);
				else  sb.Append(lines[i]).Append(symbol);

				sb.Append(StringDateUtil.LINE_SPLITTER )  ;
			}

			//remove last split char
			if(sb.Length >= StringDateUtil.LINE_SPLITTER.Length)  sb.Length -= StringDateUtil.LINE_SPLITTER.Length;
			
			return sb.ToString();

		}




	}

}
