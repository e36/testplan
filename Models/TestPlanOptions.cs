using System;
using System.Text.Json;
using System.Collections.Generic;

namespace testplan.Modelse
{
    public class TestPlanOptions
    {
        public string testPlanFolderPath;

        public List<FileOptionItem> componentFiles;

        public List<FileOptionItem> testPlanFiles;

    }
}
