using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FileHelpers;

namespace cpSQLserverMVC.Models
{
    public class Parser
    {

        private string _filePath;
        public Parser(string filePath)
        {
            _filePath = filePath;
        }

        public WEBFORMFIELD[] Parse()
        {
            var engine = new FileHelperEngine<cpSQLserverMVC.Models.WEBFORMFIELD>();
            cpSQLserverMVC.Models.WEBFORMFIELD[] res = engine.ReadFile(@"YourFile.txt");
            return engine.ReadFile(_filePath);
        }
    }
}