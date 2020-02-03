using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISeries
{
	public interface ISeries
	{
		int GetNext();
		void Reset();
		void SetStart(int x);
		int GetPrevious();
	}
}

