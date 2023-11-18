fn high_and_low(numbers: &str) -> String {
    let numbers: Vec<i32> = numbers
        .split_whitespace()
        .map(|s| s.parse().unwrap()) // Parse into i32
        .collect(); // Collect into a Vec
    format!(
        "{} {}",
        numbers.iter().max().unwrap(),
        numbers.iter().min().unwrap()
    )
}
