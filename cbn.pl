% Author: Yujie Liu
% Partner: Po-Chun Chiu
% CSC254 A1 Prolog Combination

aux(0, _, []). % This rule states that [] is a 0-combination of anything. 
aux(K, L, [H | TL]) :- 
	K > 0, K2 is K-1, sublist(L, H, SL), aux(K2, SL, TL). 

% sublist(A, B, C) states that C is a sublist of A that does not contain B.
sublist([H | TL], H, TL).
sublist([_| TL], H, SL) :- sublist(TL, H, SL). 


% aux is the actual combination function, while cbn transforms the input N into the list [1, ..., N].
cbn(K, N, L) :- numlist(1, N, LIST), aux(K, LIST, L).


