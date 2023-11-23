# Count IP Addresses

URL: https://www.codewars.com/kata/526989a41034285187000de4

Completed At: 2023-11-06T21:00:09.792Z

Difficulty: 5 kyu

Description:

```if-not:sql
Implement a function that receives two IPv4 addresses, and returns the number of addresses between them (including the first one, excluding the last one).
```

```if:sql
Given a database of first and last IPv4 addresses, calculate the number of addresses between them (including the first one, excluding the last one).

## Input

~~~
---------------------------------
|     Table    | Column | Type  |
|--------------+--------+-------|
| ip_addresses | id     | int   |
|              | first  | text  |
|              | last   | text  |
---------------------------------
~~~

## Output

~~~
-------------------------
|   Column    |  Type   |
|-------------+---------|
| id          | int     |
| ips_between | bigint  |
-------------------------
~~~
```

All inputs will be valid IPv4 addresses in the form of strings. The last address will always be greater than the first one.

___

## Examples

```
* With input "10.0.0.0", "10.0.0.50"  => return   50 
* With input "10.0.0.0", "10.0.1.0"   => return  256 
* With input "20.0.0.10", "20.0.1.0"  => return  246
```
