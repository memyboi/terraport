for f in ./*.webp; do dwebp "$f" -o "$(basename $f .webp).png"; rm -rf "$f"; done

# This is a simple bash tool to convert .webp files (as found on the terraria.wiki.gg/ site) into .png images w/ dwebp.
# will likely not work on windows and/or mac, don't confuse urself w/ this.
# probably gonna just mass import sprites ngl
