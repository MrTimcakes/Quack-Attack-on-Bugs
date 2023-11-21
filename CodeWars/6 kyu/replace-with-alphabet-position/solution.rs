fn alphabet_position(text: &str) -> String {
    return text
        .chars() // Process string as chars
        .filter(|&c| c.is_ascii_alphabetic()) // Only allow letters
        .filter_map(|c| Some(((c.to_ascii_lowercase() as u8 - b'a') + 1).to_string())) // Convert to alphabet position
        .collect::<Vec<String>>()
        .join(" "); // Final string by joining items with a space
}
