using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yunlin.Twport.Vote.Service
{
    public class NamingRuleService
    {
        /// <summary>
        /// 測試方法
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int TestFunction(int index)
        {
            switch (index)
            {
                case 1: break;

                //下面多餘的
                //default: break;
            }

            //awful bad
            //if (index == 0) DoTrue();
            //else
            //    DoFalse();

            //good
            if (index == 0)
            {
                DoTrue();
            }
            else
            {
                DoFalse();
            }
            
            // terrible bad
            //if (DoTrue() == true) { DoTrue(); }
            //good
            if (DoTrue()) { DoTrue(); }

            // very bad
            //return (index * (index + 1) / 2);

            //good
            return index * (index + 1) / 2;
        }

        /// <summary>
        /// DoTrue
        /// </summary>
        /// <returns></returns>
        private bool DoTrue()
        {
            return true;
        }

        /// <summary>
        /// DoFalse
        /// </summary>
        /// <returns></returns>
        private bool DoFalse()
        {
            return false;
        }

        /// <summary>
        /// 測是字串方法
        /// </summary>
        /// <param name="value">值</param>
        public void TestStringFunction(string value)
        {
            //bad
            //string NewString = "ABCDEFG"; //新字串

            //good
            //新字串
            string newString = "ABCDEFG"; 

            //bad 我看不懂
            //if (value != null | value != "") value = NewString.Replace("A", ",").Replace("B", "_").Replace("C", " ");

            //good
            if (!string.IsNullOrEmpty(value))
            {
                value = new StringBuilder(newString).Replace("A", ",").Replace("B", "_").Replace("C", " ").ToString();
            }
        }

    }
}
