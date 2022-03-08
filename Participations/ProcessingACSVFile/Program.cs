//string entireFileContents = File.ReadAllText("sales_data_sample.csv");

//Console.WriteLine(entireFileContents);

string[] linesOfFile = File.ReadAllLines("sales_data_sample.csv");
//                      0             1            2            3          4       5        6        7     8      9
//linesOfFile[0] :"ORDERNUMBER,QUANTITYORDERED,PRICEEACH,ORDERLINENUMBER,SALES,ORDERDATE,STATUS,QTR_ID,MONTH_ID,YEAR_ID,PRODUCTLINE,MSRP,PRODUCTCODE,CUSTOMERNAME,PHONE,ADDRESSLINE1,ADDRESSLINE2,CITY,STATE,POSTALCODE,COUNTRY,TERRITORY,CONTACTLASTNAME,CONTACTFIRSTNAME,DEALSIZE"
// ...

int totalNumberOrder = 0;
double totalSalesFor2003 = 0;

for (int i = 1; i < linesOfFile.Length; i++)
{
    //                   0    1   2  3   4      5            6     7 8   9      10      11    12           13             14               15           1617   18 19 
    //linesOfFile[1] :"10107,30,95.7,2,2871,2/24/2003 0:00,Shipped,1,2,2003,Motorcycles,95,S10_1678,Land of Toys Inc.,2125557818,897 Long Airport Avenue,,NYC,NY,10022,USA,NA,Yu,Kwai,Small"
    string[] pieces = linesOfFile[i].Split(',');
    //pieces[0] :"10107"
    //pieces[1] :"30"
    //pieces[2] :"95.7"
    //....
    //pieces[length-1] :"Small"
    string orderNumber = pieces[0];
    ////int quantity = Convert.ToInt32(pieces[1]);
    //int quantity = int.Parse(pieces[1]);

    //totalNumberOrder += quantity;
    string status = pieces[6];
    if (status.ToLower() == "shipped")
    {
        Console.WriteLine($"Order Number: {orderNumber}\t {status}");
        if (pieces[9] == "2003") // if (Convert.ToInt32(pieces[9]) == 2003)
        {
            totalSalesFor2003 += double.Parse(pieces[4]);
        }
    }

}
Console.WriteLine($"The total sales for shipped items in 2003 was {totalSalesFor2003.ToString("C")}");
//Console.WriteLine($"\nThe total number ordered is {totalNumberOrder.ToString("N")}");