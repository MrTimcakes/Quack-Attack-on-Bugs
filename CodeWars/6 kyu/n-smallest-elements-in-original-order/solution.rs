fn first_n_smallest(arr: &[i32], n: usize) -> Vec<i32> {
    let mut indexed_values: Vec<_> = arr.iter().enumerate().collect();         // Associate each element with its index
    indexed_values.sort_by_key(|&(_, val)| val);                               // Sort elements by their values in ascending order
    let mut result: Vec<_> = indexed_values.iter().take(n).cloned().collect(); // Take the first N elements
    result.sort_by_key(|&(index, _)| index);                                   // Sort the result by the original indices to maintain the original order
    let final_result: Vec<_> = result.iter().map(|&(_, val)| *val).collect();  // Select just the values (Not value, index pairs)

    final_result
}
