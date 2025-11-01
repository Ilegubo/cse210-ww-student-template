import os; os.system('cls')
def count_words(filename: str):
    word_count = 0
    with open(filename, "r") as file:
        word_count = len(file.read().split())
        return word_count
    
if __name__ == "__main__":
    filename = "./week01/version_control.txt"
    word_count = count_words(filename)
    print(f"Number of words in file: {word_count}")