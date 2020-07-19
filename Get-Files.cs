GetFiles(List<String> List, string Path) /* Recursive */
{		  
	try
	{
		string[] Files = Directory.GetFiles(Path);

		string[] Directories = Directory.GetDirectories(Path);

		for (int I = 0; I < Files.Length; I++)
		{
			FileInfo Fi = new FileInfo(Files[I]);

			List.Add(Fi.FullName);
		}

		foreach (string Dir in Directories) { GetFiles(List, Dir); } 
	}
			
	catch { /* Pass */ }
}
