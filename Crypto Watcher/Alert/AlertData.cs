﻿/******************************************************************************
 * CRYPTO WATCHER - cryptocurrency alert system that notifies you when certain 
 * cryptocurrency fulfills your condition.
 * Copyright (c) 2017-2018 Stock84-dev
 * https://github.com/Stock84-dev/Crypto-Watcher
 *
 * This file is part of CRYPTO WATCHER.
 *
 * CRYPTO WATCHER is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * CRYPTO WATCHER is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with CRYPTO WATCHER.  If not, see <http://www.gnu.org/licenses/>.
 *****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoWatcher.Utilities;
namespace CryptoWatcher.Alert
{
	// data that is required for all alerts
	struct AlertData
	{
		public AlertData(string baseSymbol, string quoteSymbol, string baseName, string exchangeName)
		{
			BaseSymbol = baseSymbol;
			QuoteSymbol = quoteSymbol;
			BaseName = baseName;
			ExchangeName = exchangeName;
		}
        // creates alert data from csv line
		public AlertData(ref string data)
		{
			BaseSymbol = Utility.GetSubstring(data, ';', 0);
			QuoteSymbol = Utility.GetSubstring(data, ';', 1);
			BaseName = Utility.GetSubstring(data, ';', 2);
			ExchangeName = Utility.GetSubstring(data, ';', 3);
			data = Utility.GetSubstring(data, ';', 4, false);
		}

		public string BaseSymbol { get; set; }
		public string QuoteSymbol { get; set; }
		public string BaseName { get; set; }
		public string ExchangeName { get; set; }

        // gets csv line
		public override string ToString()
		{
			return $"{BaseSymbol};{QuoteSymbol};{BaseName};{ExchangeName}";
		}
	}
}
