for f in ./*.webp; do dwebp "$f" -o "$(basename $f .webp).png"; rm -rf "$f"; done
