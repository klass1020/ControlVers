string[] n = {"Hello","2","world","123"};
string[] result =new string[2];
int a = 0;
for(int i=0; i < 4; i++){
    if (n[i].Length < 4){
        result[a] = n[i];
        a = a + 1;
    }
}
