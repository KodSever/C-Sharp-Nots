//Start stop ile yazılımın performansını ölçebiliriz.

using System.Diagnostics;
Stopwatch sw = Stopwatch.StartNew();
Random r = new Random();
int[] dizi = new int[100000000];
for (int i = 0; i < dizi.Length; i++)
{
  dizi[i] = r.Next(0, 100000000);
}
sw.Stop();
MessageBox.Show(sw.ElapsedMilliseconds.ToString());
