Console.WriteLine("bir sayı girin: ");
int n = Convert.ToInt32(Console.ReadLine());

int [] numbers = new int [n];

for(int i = 0; i<n; i++){
    Console.WriteLine("{0}.sayıyı girin:  ", i+1);
    numbers[i] = Convert.ToInt32(Console.ReadLine());

}
Console.WriteLine("Çift sayılar : ");
foreach(int number in numbers){
    if(number%2==0){
    Console.WriteLine(number);

    }
}
