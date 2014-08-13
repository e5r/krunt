krunt
=====

_Port do Grunt.js para a nova tecnologia Microsoft .NET vNext._

Não chega a ser um port do Grunt.js para a nova tecnologia Microsoft .NET vNext. Eu quero na verdade aproveitar os ótimos conceitos que o Grunt.js nos permite aplicar no fluxo de desenvolvimento (principalmente front-end), e aplicá-los também para definir um fluxo semelhante para o desenvolvimento web na nova tecnologia que a Microsoft está lançando, o ASP.NET vNext.

A ideia inicial é implementar as tarefas mais básicas para o desenvolvimento front-end, principalmente de bibliotecas JavaScript:

* Concatenar
* Minificar
* Assistir (Watch)
* Empacotar

O Grunt.js se baseia em um arquivo _Gruntfile.js_ que além de conter as configurações.
Ex:

```javascript
grunt.initConfig({
  pkg: grunt.file.readJSON('package.json'),
  uglify: {
    options: {
      banner: '/*! <%= pkg.name %> My Project */\n'
    },
    build: {
      src: 'src/<%= pkg.name %>.js',
      dest: 'build/<%= pkg.name %>.min.js'
    }
  }
});
```

Também executa código:

```javascript
grunt.loadNpmTasks('grunt-contrib-uglify');

grunt.registerTask('default', ['uglify']);
```

Com o __Krunt__ pretendo fazer um pouco diferente, mantendo a configuração em um arquivo de configuração chamado _Krunt.json_. Nesse caso o registro de tarefas e (talvez) o carregamento de submódulos seja feito também via arquivo de configuração.

As tarefas (aqui leia-se plugin) por sua vez podem ser extendidas, ou seja, poderão ser criadas novas tarefas.

Conclusão
=========

Por enquanto é só uma ideia, mas de acordo com que a implementação for sendo feita, a documentação será atualizada.
