# Depglass Walkthrough

This note is the quickest way to read the extra review model in `depglass`.

| Case | Focus | Score | Lane |
| --- | --- | ---: | --- |
| baseline | change width | 188 | ship |
| stress | diagnostic quality | 206 | ship |
| edge | review cost | 226 | ship |
| recovery | safe rewrite | 191 | ship |
| stale | change width | 227 | ship |

Start with `stale` and `baseline`. They create the widest contrast in this repository's fixture set, which makes them better review anchors than the middle cases.

If `baseline` becomes less cautious without a clear reason, I would inspect the drag input first.
