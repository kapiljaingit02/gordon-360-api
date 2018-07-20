# Printing in color.

try:
    import colorama
    colorama.init()
except:
    try:
        import tendo.ansiterm
    except:
        pass

USE_ANSI_COLORS = True

if USE_ANSI_COLORS:
    HEADER = '\033[35m'
    OKBLUE = '\033[1m\033[34m'
    OKGREEN = '\033[1m\033[32m'
    WARNING = '\033[1m\033[33m'
    FAIL = '\033[1m\033[31m'
    ENDC = '\033[0m'
    BOLD = '\033[1m'
    UNDERLINE = '\033[4m'
else:
    HEADER = ''
    OKBLUE = ''
    OKGREEN = ''
    WARNING = ''
    FAIL = ''
    ENDC = ''
    BOLD = ''
    UNDERLINE = ''