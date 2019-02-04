# ParallelFor

[Task Parallel Library (TPL)](https://docs.microsoft.com/en-us/dotnet/standard/parallel-programming/task-parallel-library-tpl)
[Intel Core i5-5300U Processor](https://ark.intel.com/products/85213)

### The Benchmark

![cpu](cpu.png)



Dual Core CPU with 2 Threads per Core.

### Test #1

No TPL ParallelFor execution, system idling.

![0-parallelfor-thread-execution](0-parallelfor-thread-execution.PNG)

### Test #2

Parallel.For MaxDegreeOfParallelism = 1

![1-parallelfor-thread-execution](1-parallelfor-thread-execution.PNG)

### Test #3

Parallel.For MaxDegreeOfParallelism = 2

![2-parallelfor-thread-execution](2-parallelfor-thread-execution.PNG)

### Test #4

Parallel.For MaxDegreeOfParallelism = 3

![3-parallelfor-thread-execution](3-parallelfor-thread-execution.PNG)

### Test #5

Parallel.For MaxDegreeOfParallelism = 4

![4-parallelfor-thread-execution](4-parallelfor-thread-execution.PNG)