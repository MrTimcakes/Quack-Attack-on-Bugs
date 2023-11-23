import requests
import os
import re
from pathlib import Path

username = "MrTimcakes"

file_extension_map = {
    "ruby": ".rb",
    "javascript": ".js",
    "coffeescript": ".coffee",
    "python": ".py",
    "clojure": ".clj",
    "haskell": ".hs",
    "java": ".java",
    "csharp": ".cs",
    "swift": ".swift",
    "r": ".r",
    "c": ".c",
    "cpp": ".cpp",
    "scala": ".scala",
    "nasm": ".asm",
    "go": ".go",
    "ocaml": ".ml",
    "typescript": ".ts",
    "julia": ".jl",
    "prolog": ".pl",
    "nim": ".nim",
    "elixir": ".ex",
    "crystal": ".cr",
    "factor": ".factor",
    "elm": ".elm",
    "rust": ".rs",
    "pascal": ".pas",
    "fsharp": ".fs",
    "cobol": ".cob",
    "d": ".d",
    "php": ".php",
}

def fetch_json(url):
    response = requests.get(url)
    response.raise_for_status()
    return response.json()

def create_directory(path):
    # print(f"Creating directory {path}")
    Path(path).mkdir(parents=True, exist_ok=True)

def save_to_file(path, content):
    # print(f"Saving to {path} -> {content}")
    with open(path, 'w', encoding="utf-8") as file:
        file.write(content)

# def filter_description(description, completed_languages):
#     # Regular expressions for code segments and language-specific if statements
#     code_segment_regex = re.compile(r"```(\w+)[\s\S]+?```")
#     language_if_regex = re.compile(r"~~~if:(\w+)[\s\S]+?~~~")

#     # Filter code segments
#     filtered_description = ""
#     for segment in code_segment_regex.finditer(description):
#         language = segment.group(1)
#         if language in completed_languages:
#             filtered_description += segment.group(0) + "\n\n"

#     # Filter language-specific if statements
#     filtered_description = language_if_regex.sub(lambda m: m.group(0) if m.group(1) in completed_languages else '', filtered_description)

#     return filtered_description

def process_challenge(challenge):
    # Fetch challenge details
    challenge_detail = fetch_json(f"https://codewars.com/api/v1/code-challenges/{challenge['id']}")

    # Define directory path
    difficulty = challenge_detail['rank']['name']
    slug = challenge_detail['slug']
    dir_path = f"{difficulty}/{slug}"

    # Determine if directory and readme need to be created
    if not os.path.exists(dir_path):
        print(f"Creating entry for: {challenge_detail['name']}")
        create_directory(dir_path)

        # Prepare and save readme content only if directory is newly created
        readme_content = f"# {challenge_detail['name']}\n\n" \
                         f"URL: {challenge_detail['url']}\n\n" \
                         f"Completed At: {challenge['completedAt']}\n\n" \
                         f"Difficulty: {difficulty}\n\n" \
                         f"Description:\n\n{challenge_detail.get('description', 'No description')}"
        
        save_to_file(f"{dir_path}/readme.md", readme_content)

    # Process each language for the challenge
    for language in challenge['completedLanguages']:
        file_extension = file_extension_map.get(language, ".txt")
        solution_file_path = f"{dir_path}/solution{file_extension}"

        # Create solution file only if it does not exist
        if not os.path.exists(solution_file_path):
            solution_content = "// TODO: Copy from CodeWars\n"
            print(f"Creating solution file for {language} at {solution_file_path}")
            save_to_file(solution_file_path, solution_content)



def main():
    user_challenges = fetch_json(f"https://codewars.com/api/v1/users/{username}/code-challenges/completed")

    # process_challenge(user_challenges['data'][0]) # For testing only process one challenge

    for challenge in user_challenges['data']:
        print(f"Processing {challenge['id']}...")
        process_challenge(challenge)
        print()

if __name__ == "__main__":
    main()
