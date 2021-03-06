
#region Apache Notice
/*****************************************************************************
 * $Header: $
 * $Revision: 383115 $
 * $Date: 2008-06-28 09:26:16 -0600 (Sat, 28 Jun 2008) $
 * 
 * iBATIS.NET Data Mapper
 * Copyright (C) 2008/2005 - The Apache Software Foundation
 *  
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *      http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 ********************************************************************************/
#endregion

#region Using
using System;
using System.Xml.Serialization;

using MyBatis.DataMapper.Model.Sql.Dynamic.Handlers;
#endregion


namespace MyBatis.DataMapper.Model.Sql.Dynamic.Elements
{
	/// <summary>
	/// Summary description for Conditional.
	/// </summary>
	[Serializable]
	public abstract class Conditional : BaseTag
	{		
		[NonSerialized]
		private string compareValue = string.Empty;
		[NonSerialized]
		private string compareProperty = string.Empty;
        
		/// <summary>
		/// CompareProperty attribute
		/// </summary>
		public string CompareProperty
		{
			get { return compareProperty; }
			set { compareProperty = value; }
		}


		/// <summary>
		/// CompareValue attribute
		/// </summary>
		public string CompareValue
		{
			get { return compareValue; }
			set { compareValue = value; }
		}
	}
}
