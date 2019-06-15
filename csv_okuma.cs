//CSV OKUMA
listA = new List<string>();
listB = new List<string>();

while (!reader.EndOfStream)
{
  var line = reader.ReadLine();
  var values = line.Split(',');

  listA.Add(values[0]);

  listB.Add(values[1]);
}
