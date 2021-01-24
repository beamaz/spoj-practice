namespace KabalistycznyZapisDaty
{
    public static class KabbalahConverter
    {
        public static int ConvertCharToKabbalahNumber(char letter)
        {
            switch (letter)
            {
                case 'A':
                    return 1;
                case 'B':
                    return 2;
                case 'C':
                    return 3;
                case 'D':
                    return 4;
                case 'E':
                    return 5;
                case 'F':
                    return 6;
                case 'G':
                    return 7;
                case 'H':
                    return 8;
                case 'I':
                    return 9;
                case 'K':
                    return 10;
                case 'L':
                    return 20;
                case 'M':
                    return 30;
                case 'N':
                    return 40;
                case 'O':
                    return 50;
                case 'P':
                    return 60;
                case 'Q':
                    return 70;
                case 'R':
                    return 80;
                case 'S':
                    return 90;
                case 'T':
                    return 100;
                case 'V':
                    return 200;
                case 'X':
                    return 300;
                case 'Y':
                    return 400;
                default:
                    return 500;
            }
        }
    }
}