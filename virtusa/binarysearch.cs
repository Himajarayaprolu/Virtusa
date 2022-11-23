binarysearch.cs
public static binarysearch(int[] arr, int num)
{
    int min = 0;
    int max = arr.Length-1;
    while (min<0)
    {
        
    }
    int mid = min+max/2;
    if(num<mid){
        max=mid;
    }
    else{
        max=min;
    }


}




public static BinarySearch(int[] arr, int key) {
   int min = 0;
   int max = arr.Length - 1;

   while (min<=max) {
      int mid = (min + max) / 2;
      if (key == arr[mid]) 
      {
         return ++mid;
      } else if (key < arr[mid])
      {
         max = mid - 1;
      }
      else {
         min = mid + 1;
      }
   }
   return "Not found";
}