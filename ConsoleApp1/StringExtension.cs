﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;

public static class StringExtension
{
    public static string ToUpperFirst(this string s)
    {
        return char.ToUpper(s[0]) + s.Substring(1);
    }
    public static string Right(this string s, int aantal)
    {
        if (s.Length <= aantal)
        return s;
        return s.Substring(s.Length - aantal);
    }
}
