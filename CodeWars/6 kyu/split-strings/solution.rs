fn solution(s: &str) -> Vec<String> {
    (0..s.len()) // Range from 0 -> length
        .step_by(2) // Process in pairs
        .map(|i| format!("{}{}", &s[i..=i], s.get(i + 1..=i + 1).unwrap_or("_"))) // Format to s[i] + s[i+1] ?? _
        .collect() // Collect into Vec<String>
}
