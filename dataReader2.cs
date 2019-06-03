//DATAREADER2
OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=KISIADRESLER.accdb;Persist Security Info = False;");
private void button1_Click(object sender, EventArgs e)
{
  baglan.Open();
  listBox1.Items.Clear();
  OleDbCommand komut = new OleDbCommand("Select * from Kisiler", baglan);
  OleDbDataReader oku = komut.ExecuteReader();
  while (oku.Read()) 
  {
    listBox1.Items.Add(
    oku["ID"] + "-" + 
    oku["AD"] + " " + 
    oku["SOYAD"]);
  }
  baglan.Close();
}
