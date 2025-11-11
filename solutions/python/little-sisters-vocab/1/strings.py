"""Functions for creating, transforming, and adding prefixes to strings."""


def add_prefix_un(word):
    """Take the given word and add the 'un' prefix.

    :param word: str - containing the root word.
    :return: str - of root word prepended with 'un'.
    """
    prefix = 'un'
    updated_word = prefix + word
    return updated_word


def make_word_groups(vocab_words):
    """Transform a list containing a prefix and words into a string with the prefix followed by the words with prefix prepended.

    :param vocab_words: list - of vocabulary words with prefix in first index.
    :return: str - of prefix followed by vocabulary words with
            prefix applied.

    This function takes a `vocab_words` list and returns a string
    with the prefix and the words with prefix applied, separated
     by ' :: '.

    For example: list('en', 'close', 'joy', 'lighten'),
    produces the following string: 'en :: enclose :: enjoy :: enlighten'.
    """
    prefix = vocab_words[0]
    # Build list with the prefix itself followed by each word with the prefix applied
    groups = [prefix]
    for word in vocab_words[1:]:
        groups.append(prefix + word)

    return ' :: '.join(groups)


def remove_suffix_ness(word):
    """Remove the suffix from the word while keeping spelling in mind.

    :param word: str - of word to remove suffix from.
    :return: str - of word with suffix removed & spelling adjusted.

    For example: "heaviness" becomes "heavy", but "sadness" becomes "sad".
    """
    # Only operate if the word actually ends with 'ness'
    if not word.endswith('ness'):
        return word

    root = word[:-4]  # remove 'ness'
    # If the remaining root ends with 'i', change it to 'y' (heavi -> heavy)
    if root.endswith('i'):
        root = root[:-1] + 'y'

    return root



def adjective_to_verb(sentence, index):
    """Change the adjective within the sentence to a verb.

    :param sentence: str - that uses the word in sentence.
    :param index: int - index of the word to remove and transform.
    :return: str - word that changes the extracted adjective to a verb.

    For example, ("It got dark as the sun set.", 2) becomes "darken".
    """
    # Split the sentence into words, strip punctuation from the selected word,
    # and append 'en' to convert the adjective to a verb.
    words = sentence.split()

    # Select the word by index (supports negative indexes)
    selected = words[index].strip('.,!?:;')

    return selected + 'en'


    

