/*
CLRUtilFunctions string aggregate for SQL Server - https://github.com/chjsoliveira/SQLCLR_Library
Copyright (C) 2021  Carlos Oliveira - chjs.oliveira@gmail.com

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or 
any later version.
This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.
See http://www.gnu.org/licenses/ for a copy of the GNU General Public 
License.
*/
using System.Text.RegularExpressions;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

namespace StringUtils
{
    public partial class StringUtils
    {
        [SqlFunction]
        public static string ReplaceRegex(SqlString strText, SqlString strRegexSearch, SqlString strTextReplace)
        {
            return Regex.Replace(strText.Value, strRegexSearch.Value, strTextReplace.Value, RegexOptions.Compiled);

        }
    }

}
