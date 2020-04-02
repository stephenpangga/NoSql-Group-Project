using MongoDB.Bson;
using NosqlModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NosqlUI
{
	public class ComboItem : object
	{
		public string m_Name;
		public User m_user;

		public ComboItem(string name, User value)
		{
			m_Name = name;
			m_user = value;
		}

		public override string ToString()
		{
			return m_Name;
		}

	};
}
