Program SumCalc;
{ some sample code }
var 
    num :Integer;
    sum :Integer;
    i   :Integer;
    
begin
    write( 'Enter a number: ' );
    readln( input , num );
    writeln( num );
    
    sum := 0;
    for i := 0 to num do
    begin
	sum := sum + i;
    end;
        
    write( 'Sum of numbers up to ' , num );
    writeln( ' is: ' , sum );
        
end.