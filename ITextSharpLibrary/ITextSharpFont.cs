using iTextSharp.text;

namespace ITextSharpLibrary
{
    public class ITextSharpFont
    {
        /// <summary>
        /// Font Size 24, Font Type Normal
        /// </summary>
        /// <param name="value">String Type Value</param>
        /// <returns></returns>
        public static Phrase H1Normal(string value)
        {
            return new Phrase(value, FontFactory.GetFont(FontFactory.TIMES_ROMAN, 24, Font.NORMAL));
        }


        /// <summary>
        /// Font Size 22, Font Type Normal
        /// </summary>
        /// <param name="value">String Type Value</param>
        /// <returns></returns>
        public static Phrase H2Normal(string value)
        {
            return new Phrase(value, FontFactory.GetFont(FontFactory.TIMES_ROMAN, 22, Font.NORMAL));
        }


        /// <summary>
        /// Font Size 18, Font Type Normal
        /// </summary>
        /// <param name="value">String Type Value</param>
        /// <returns></returns>
        public static Phrase H3Normal(string value)
        {
            return new Phrase(value, FontFactory.GetFont(FontFactory.TIMES_ROMAN, 18, Font.NORMAL));
        }


        /// <summary>
        /// Font Size 16, Font Type Normal
        /// </summary>
        /// <param name="value">String Type Value</param>
        /// <returns></returns>
        public static Phrase H4Normal(string value)
        {
            return new Phrase(value, FontFactory.GetFont(FontFactory.TIMES_ROMAN, 16, Font.NORMAL));
        }


        /// <summary>
        /// Font Size 12, Font Type Normal
        /// </summary>
        /// <param name="value">String Type Value</param>
        /// <returns></returns>
        public static Phrase H5Normal(string value)
        {
            return new Phrase(value, FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, Font.NORMAL));
        }


        /// <summary>
        /// Font Size 10, Font Type Normal
        /// </summary>
        /// <param name="value">String Type Value</param>
        /// <returns></returns>
        public static Phrase H6Normal(string value)
        {
            return new Phrase(value, FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, Font.NORMAL));
        }

        /// <summary>
        /// Font Size 8, Font Type Normal
        /// </summary>
        /// <param name="value">String Type Value</param>
        /// <returns></returns>
        public static Phrase H7Normal(string value)
        {
            return new Phrase(value, FontFactory.GetFont(FontFactory.TIMES_ROMAN, 8, Font.NORMAL));
        }


        /// <summary>
        /// Font Size 24, Font Type Bold
        /// </summary>
        /// <param name="value">String Type Value</param>
        /// <returns></returns>
        public static Phrase H1Bold(string value)
        {
            return new Phrase(value, FontFactory.GetFont(FontFactory.TIMES_ROMAN, 24, Font.BOLD));
        }


        /// <summary>
        /// Font Size 22, Font Type Bold
        /// </summary>
        /// <param name="value">String Type Value</param>
        /// <returns></returns>
        public static Phrase H2Bold(string value)
        {
            return new Phrase(value, FontFactory.GetFont(FontFactory.TIMES_ROMAN, 22, Font.BOLD));
        }


        /// <summary>
        /// Font Size 18, Font Type Bold
        /// </summary>
        /// <param name="value">String Type Value</param>
        /// <returns></returns>
        public static Phrase H3Bold(string value)
        {
            return new Phrase(value, FontFactory.GetFont(FontFactory.TIMES_ROMAN, 18, Font.BOLD));
        }

        /// <summary>
        /// Font Size 16, Font Type Bold
        /// </summary>
        /// <param name="value">String Type Value</param>
        /// <returns></returns>
        public static Phrase H4Bold(string value)
        {
            return new Phrase(value, FontFactory.GetFont(FontFactory.TIMES_ROMAN, 16, Font.BOLD));
        }


        /// <summary>
        /// Font Size 12, Font Type Bold
        /// </summary>
        /// <param name="value">String Type Value</param>
        /// <returns></returns>
        public static Phrase H5Bold(string value)
        {
            return new Phrase(value, FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, Font.BOLD));
        }


        /// <summary>
        /// Font Size 10, Font Type Bold
        /// </summary>
        /// <param name="value">String Type Value</param>
        /// <returns></returns>
        public static Phrase H6Bold(string value)
        {
            return new Phrase(value, FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, Font.BOLD));
        }


        /// <summary>
        /// Font Size 8, Font Type Bold
        /// </summary>
        /// <param name="value">String Type Value</param>
        /// <returns></returns>
        public static Phrase H7Bold(string value)
        {
            return new Phrase(value, FontFactory.GetFont(FontFactory.TIMES_ROMAN, 8, Font.BOLD));
        }


        /// <summary>
        /// Font Size 24, Font Type Italic
        /// </summary>
        /// <param name="value">String Type Value</param>
        /// <returns></returns>
        public static Phrase H1Italic(string value)
        {
            return new Phrase(value, FontFactory.GetFont(FontFactory.TIMES_ROMAN, 24, Font.ITALIC));
        }

        /// <summary>
        /// Font Size 22, Font Type Italic
        /// </summary>
        /// <param name="value">String Type Value</param>
        /// <returns></returns>
        public static Phrase H2Italic(string value)
        {
            return new Phrase(value, FontFactory.GetFont(FontFactory.TIMES_ROMAN, 22, Font.ITALIC));
        }

        /// <summary>
        /// Font Size 18, Font Type Italic
        /// </summary>
        /// <param name="value">String Type Value</param>
        /// <returns></returns>
        public static Phrase H3Italic(string value)
        {
            return new Phrase(value, FontFactory.GetFont(FontFactory.TIMES_ROMAN, 18, Font.ITALIC));
        }

        /// <summary>
        /// Font Size 16, Font Type Italic
        /// </summary>
        /// <param name="value">String Type Value</param>
        /// <returns></returns>
        public static Phrase H4Italic(string value)
        {
            return new Phrase(value, FontFactory.GetFont(FontFactory.TIMES_ROMAN, 16, Font.ITALIC));
        }

        /// <summary>
        /// Font Size 12, Font Type Italic
        /// </summary>
        /// <param name="value">String Type Value</param>
        /// <returns></returns>
        public static Phrase H5Italic(string value)
        {
            return new Phrase(value, FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, Font.ITALIC));
        }

        /// <summary>
        /// Font Size 10, Font Type Italic
        /// </summary>
        /// <param name="value">String Type Value</param>
        /// <returns></returns>
        public static Phrase H6ItalicBold(string value)
        {
            return new Phrase(value, FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, Font.ITALIC));
        }

        /// <summary>
        /// Font Size 8, Font Type Italic
        /// </summary>
        /// <param name="value">String Type Value</param>
        /// <returns></returns>
        public static Phrase H7Italic(string value)
        {
            return new Phrase(value, FontFactory.GetFont(FontFactory.TIMES_ROMAN, 8, Font.ITALIC));
        }


        /// <summary>
        /// Font Size 24, Font Type BoldItalic
        /// </summary>
        /// <param name="value">String Type Value</param>
        /// <returns></returns>
        public static Phrase H1BoldItalic(string value)
        {
            return new Phrase(value, FontFactory.GetFont(FontFactory.TIMES_ROMAN, 24, Font.BOLDITALIC));
        }

        /// <summary>
        /// Font Size 22, Font Type BoldItalic
        /// </summary>
        /// <param name="value">String Type Value</param>
        /// <returns></returns>
        public static Phrase H2BoldItalic(string value)
        {
            return new Phrase(value, FontFactory.GetFont(FontFactory.TIMES_ROMAN, 22, Font.BOLDITALIC));
        }

        /// <summary>
        /// Font Size 18, Font Type BoldItalic
        /// </summary>
        /// <param name="value">String Type Value</param>
        /// <returns></returns>
        public static Phrase H3BoldItalic(string value)
        {
            return new Phrase(value, FontFactory.GetFont(FontFactory.TIMES_ROMAN, 18, Font.BOLDITALIC));
        }

        /// <summary>
        /// Font Size 16, Font Type BoldItalic
        /// </summary>
        /// <param name="value">String Type Value</param>
        /// <returns></returns>
        public static Phrase H4BoldItalic(string value)
        {
            return new Phrase(value, FontFactory.GetFont(FontFactory.TIMES_ROMAN, 16, Font.BOLDITALIC));
        }

        /// <summary>
        /// Font Size 12, Font Type BoldItalic
        /// </summary>
        /// <param name="value">String Type Value</param>
        /// <returns></returns>
        public static Phrase H5BoldItalic(string value)
        {
            return new Phrase(value, FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, Font.BOLDITALIC));
        }

        /// <summary>
        /// Font Size 10, Font Type BoldItalic
        /// </summary>
        /// <param name="value">String Type Value</param>
        /// <returns></returns>
        public static Phrase H6BoldItalic(string value)
        {
            return new Phrase(value, FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, Font.BOLDITALIC));
        }

        /// <summary>
        /// Font Size 8, Font Type BoldItalic
        /// </summary>
        /// <param name="value">String Type Value</param>
        /// <returns></returns>
        public static Phrase H7BoldItalic(string value)
        {
            return new Phrase(value, FontFactory.GetFont(FontFactory.TIMES_ROMAN, 8, Font.BOLDITALIC));
        }
    }
}
