﻿// Octopus MFS is an integrated suite for managing a Micro Finance Institution: 
// clients, contracts, accounting, reporting and risk
// Copyright © 2006,2007 OCTO Technology & OXUS Development Network
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License along
// with this program; if not, write to the Free Software Foundation, Inc.,
// 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
//
// Website: http://www.opencbs.com
// Contact: contact@opencbs.com

using System;
using System.Collections.Generic;

namespace OpenCBS.CoreDomain
{
	/// <summary>
	/// Summary description for ProvinceArea.
    /// </summary>
    [Serializable]
	public class Province
	{
		private int _id;
		private string _name;
        private bool _deleted = false;

	    private List<District> _districts; 

		public Province() {}

		public Province(int id,string name)
		{
			_id = id;
			_name = name;
		}
		
		public Province(string name)
		{
			_name = name;
		}

		public int Id
		{
			get
			{
				return _id;
			}
			set
			{
				_id = value;
			}
		}

		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				_name = value;
			}
		}

        public bool Deleted
        {
            get
            {
                return _deleted;
            }
            set
            {
                _deleted = value;
            }
        }

        public List<District> Districts
        {
            get
            {
                return _districts;
            }
            set
            {
                _districts = value;
            }
        }



        public override string ToString()
		{
			return _name;
		}
	}
}
