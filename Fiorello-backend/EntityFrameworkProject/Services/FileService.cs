using EntityFrameworkProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkProject.Services
{ 
    public class FileService : IFileService
    {
        public string ReadFile(string path, string template)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                template = reader.ReadToEnd();
            }
            return template;
        }
    }
}
