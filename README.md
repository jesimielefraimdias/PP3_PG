# Projeto Parcial 4 - Computação Gráfica
Prof. Dr. Mario Liziér & Prof. Dr. Siovani Felipussi

## Integrantes
Jesimiel Efraim Dias,
Lucas Henrique de Araújo,
Rafael Pincinato Toledo,
Victor Mendes,
Victória Resende.

## Instruções de uso
Utilizamos o Unity na versão 2020.3.21f1 (64-bit), uma plataforma de desenvolvimento 3D, bastante usada na criação de jogos.
Para facilitar a visualização, foi disponibilizado um executável de nome *My Project*, que é o projeto previamente buildado. O campo de visão se ajusta para a resolução do monitor que está sendo exibido, por isso é recomendado um monitor com a resolução 16:9.

## Ambientação
Foram adicionados um chão com textura de grama para se ter uma maior percepção do espaço em que os objetos se encontram, três câmera para a visualização dos objetos e uma luz para auxiliar na percepção de profundidade.

##  Objetos 3D
Os objetos adicionados foram um cilindro, uma composição de cubos, uma árvore, um relógio e uma engrenagem. Após isso, redimensionamos e posicionamos individualmente cada um dos objetos na cena em frente à câmera com um espaçamento entre eles.
**Conceitos mapeados por objeto:**

*Cilindro:*

Posição
X:-15, Y:5, Z:12


*Cubos:*

Posição
X:-5, Y:5, Z:3


*Árvore:*

Posição
X:15, Y:0, Z:3


*Relógio:*

Posição
X:25, Y:5, Z:3

Rotação
X:0, Y:270, Z:0


*Engrenagem:*

Posição
X:5, Y:5, Z:3


## Scripts
No script do cilindro, temos a opção de movimentar essa forma geométrica pelo eixo Z uma unidade por vez, usando as teclas 5 e 8.
Além disso, é possível trocarmos a posição do cilindro com o cubo que estão a uma distância de 10 unidades entre si, no eixo X.
O script do cubo acompanha os movimentos realizados pelo cilindro. Seus movimentos são completamente dependentes da posição em que se encontra o cilindro.
O script do relógio faz com que o relógio gire no sentido anti-horário.
O script do ponteiro faz com que o ponteiro rode loucamente.
