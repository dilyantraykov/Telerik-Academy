function s(a){return +(a[0]>0)+(a[1]<0)*2}

var tests = [
['-1','-2'],
['1','-2'],
['-1','2'],
['1','2']
];

tests.forEach(function(test) {
	console.log(s(test));
})